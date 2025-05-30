﻿using TDSKP.API.Infrastructure.Persistence;

namespace TDSKP.API.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetByUserIdAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
