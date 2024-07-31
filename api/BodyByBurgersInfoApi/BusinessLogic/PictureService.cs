using AutoMapper;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class PictureService : ServiceBase<Picture, PictureDto>, IService<Picture, PictureDto>
    {
        public PictureService(InfoContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}