using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.Interfaces
{
    public interface IRepository<T> where T : IDomainAggregateRoot
    {
        bool Exists(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<T> SaveAsync(T entity);
        /* Data Reader Operations */
        TEntity Get<TEntity>(int id) where TEntity : IDomainEntity;
        Task<TEntity> GetAsync<TEntity>(int id) where TEntity : IDomainEntity;
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : IDomainEntity;
        Task<IQueryable<TEntity>> GetAllAsync<TEntity>() where TEntity : IDomainEntity;
        /* Data Writer Operations */
        bool CreateOrUpdate<TEntity>(TEntity entity) where TEntity : IDomainEntity;
        Task<bool> CreateOrUpdateAsync<TEntity>(TEntity entity) where TEntity : IDomainEntity;
        bool Delete<TEntity>(TEntity entity) where TEntity : IDomainEntity;
        Task<bool> DeleteAsync<TEntity>(TEntity entity) where TEntity : IDomainEntity;
    }
}
