namespace BodyByBurgersInfoApi.BusinessLogic
{
    public interface IService<TEntity, TDto>
    {
        Task<IEnumerable<TDto>> GetAsync();
        Task<TDto> CreateAsync(TDto dto);
    }
}