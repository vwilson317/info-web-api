using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class ReviewService : ServiceBase<Review, ReviewDto>, IService<Review, ReviewDto>
    {
        public ReviewService(InfoContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<IEnumerable<ReviewDto>> GetAsync()
        {
            var entities = await _dbContext.Review
                .Include(r => r.Ingredients)
                .ToListAsync();
            return _mapper.Map<IEnumerable<ReviewDto>>(entities);
        }

        public override async Task<ReviewDto> CreateAsync(ReviewDto dto)
        {
            var entity = _mapper.Map<Review>(dto);
            entity.Ingredients = await _dbContext.Ingredient
                .Where(i => dto.Ingredients.Select(x => x.Name).Contains(i.Name))
                .ToListAsync();

            _dbContext.Review.Add(entity);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<ReviewDto>(entity);
        }
    }
}