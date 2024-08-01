namespace BodyByBurgersInfoApi.BusinessLogic
{
    public interface IService<TEntity, TDto>
    {
        Task<IEnumerable<TDto>> GetAsync();
        Task<TDto> GetAsync(int id);
        Task<IEnumerable<TDto>> GetAsync(Func<TEntity, bool> predicate);
        Task<TDto> CreateAsync(TDto dto);
    }
}