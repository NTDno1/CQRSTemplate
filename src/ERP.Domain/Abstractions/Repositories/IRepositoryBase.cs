﻿using System.Linq.Expressions;
using ERP.Share.Enumerations;

namespace ERP.Domain.Abstractions.Repositories;

public interface IRepositoryBase<TEntity, in TKey> where TEntity : class
{
    Task<TEntity> FindByIdAsync(TKey id, CancellationToken cancellationToken = default, params Expression<Func<TEntity, object>>[] includeProperties);

    Task<TEntity> FindSingleAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellationToken = default, params Expression<Func<TEntity, object>>[] includeProperties);

    IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);

    Task Add(TEntity entity);

    void Update(TEntity entity);

    void Remove(TEntity entity);

    void RemoveMultiple(List<TEntity> entities);

    Task<string> GenerateCode(Func<TEntity, string> codeSelector, Prefix prefix);

}
