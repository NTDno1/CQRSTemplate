﻿using System.Security.Claims;
using ERP.Application.Abstractions.Authentication;
using ERP.Application.Abstractions.Caching;
using ERP.Domain.Entities.System.Users;
using ERP.Infrastructure.DependencyInjection.Options;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Responses.Token;
using Microsoft.Extensions.Options;
using IAuthenticationService = ERP.Application.Abstractions.Authentication.IAuthenticationService;

namespace ERP.Infrastructure.Authentication;
public class AuthenticationService : IAuthenticationService
{
    private static readonly Error ErrorUserOrPass = new Error("LoginFailed", "Tài khoản hoặc mật khẩu không chính xác!");
    private static readonly Error AccountLock = new Error("AccountLocked", "Tài khoản của bạn bị khóa do đăng nhập sai nhiều lần!");

    private readonly IJwtService _jwtService;
    private readonly IUserRepository _userRepository;
    private readonly IPasswordService _passwordService;
    private readonly ICacheService _cacheService;

    private readonly JwtOption _jwtOption;

    public AuthenticationService(
            IJwtService jwtService,
            IUserRepository userRepository,
            IPasswordService passwordService,
            ICacheService cacheService,
            IOptions<JwtOption> jwtOption
        )
    {
        _jwtService = jwtService;
        _userRepository = userRepository;
        _passwordService = passwordService;
        _cacheService = cacheService;

        _jwtOption = jwtOption.Value;
    }

    public async Task<Result<TokenResponse>> GenerateToken(string username, string password, CancellationToken cancellationToken = default)
    {
        User? checkUser = await _userRepository.FindSingleAsync(x => x.Id == username);
        if (checkUser == null)
        {
            return Result.Failure<TokenResponse>(ErrorUserOrPass);
        }
        else
        {
            string passwordUser = checkUser.PasswordHashed;
            bool checkPass = _passwordService.VerifyHashedPassword(password, passwordUser);

            if (!checkPass)
            {
                return Result.Failure<TokenResponse>(ErrorUserOrPass);
            }

            if (checkUser.IsLocked)
            {
                return Result.Failure<TokenResponse>(AccountLock);
            }

            var claims = new List<Claim>
             {
                 new Claim(ClaimTypes.Name, checkUser.Id),
                 new Claim(ClaimTypes.Sid, checkUser.Id),
             };

            string accessToken = _jwtService.GenerateAccessToken(claims);
            string refreshToken = _jwtService.GenerateRefreshToken();

            TokenResponse response = new TokenResponse()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = DateTime.Now.AddMinutes(_jwtOption.ExpireMin)
            };

            await _cacheService.SetAsync(checkUser.Id.ToString(), response, TimeSpan.FromMinutes(_jwtOption.ExpireMin), cancellationToken);

            return Result.Success(response);
        }
    }
}
