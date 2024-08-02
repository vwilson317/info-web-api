using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public abstract class ServiceBase<TEntity, TDto> : IService<TEntity, TDto>
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

        public virtual async Task<IEnumerable<TDto>> GetAsync()
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public virtual async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<TDto>(entity);
        }

        public async Task<IEnumerable<TDto>> GetAsync(Func<TEntity, bool> predicate)
        {
            //todo: find a better way to do this
            var entities = await Task.FromResult(_dbContext.Set<TEntity>().Where(predicate).ToList());
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public Task<TDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}