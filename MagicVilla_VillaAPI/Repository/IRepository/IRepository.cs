﻿using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null); //first or default some condition vachi tha yedukourom so athuku tha gett all ulla expression use panni irukom
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true); //Tracked means asnotracking use panrom athanalatha 
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
