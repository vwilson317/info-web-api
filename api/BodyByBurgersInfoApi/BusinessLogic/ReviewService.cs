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
    }
}