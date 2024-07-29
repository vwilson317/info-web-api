using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public interface IReviewService
    {
        List<Review> GetReviews();
        Task<Review> CreateAsync(ReviewDto review);
    }

    public class ReviewService: IReviewService
    {
        private readonly InfoContext _dbContext;
        private readonly IMapper _mapper;

        public ReviewService(InfoContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Review> CreateAsync(ReviewDto reviewDto)
        {
            var review = _mapper.Map<Review>(reviewDto);
            _dbContext.Reviews.Add(review);
            await _dbContext.SaveChangesAsync();
            return review;
        }

        public List<Review> GetReviews()
        {
            return _dbContext.Reviews.ToList();
        }
    }
}