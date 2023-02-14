using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null , string? includeProperties = null,int pageSize = 0,int pageNumber = 0); //first or default some condition vachi tha yedukourom so athuku tha gett all ulla expression use panni irukom
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true , string? includeProperties = null); //Tracked means asnotracking use panrom athanalatha 
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
