using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public interface IServiceBase<TEntity, TDto>
    {
        Task<IEnumerable<TDto>> GetAsync();
        Task<TDto> CreateAsync(TDto dto);
    }
    public abstract class ServiceBase<TEntity, TDto> : IServiceBase<TEntity, TDto>
    where TEntity : class
    where TDto : class
    {
        protected readonly InfoContext _dbContext;
        protected readonly IMapper _mapper;

        public ServiceBase(InfoContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

    public async Task<IEnumerable<TDto>> GetAsync()
    {
        var entities = await _dbContext.Set<TEntity>().ToListAsync();
        return _mapper.Map<IEnumerable<TDto>>(entities);
    }

    public async Task<TDto> CreateAsync(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        _dbContext.Set<TEntity>().Add(entity);
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<TDto>(entity);
    }
    }
}