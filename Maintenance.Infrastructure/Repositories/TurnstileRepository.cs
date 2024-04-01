using Maintenance.Domain.Aggregates;
using Maintenance.Domain.Interfaces;
using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Infrastructure.Repositories
{
    public class TurnstileRepository : ITurnstileRepository
    {
        public bool CreateOrUpdate<TEntity>(TEntity entity) where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateOrUpdateAsync<TEntity>(TEntity entity) where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public bool Delete<TEntity>(TEntity entity) where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Turnstile entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync<TEntity>(TEntity entity) where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public bool Exists(Turnstile entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get<TEntity>(int id) where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TEntity>> GetAllAsync<TEntity>() where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync<TEntity>(int id) where TEntity : IDomainEntity
        {
            throw new NotImplementedException();
        }

        public Task<Turnstile> SaveAsync(Turnstile entity)
        {
            throw new NotImplementedException();
        }
    }
}
