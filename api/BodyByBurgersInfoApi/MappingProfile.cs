using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Review, ReviewDto>().ReverseMap();
        CreateMap<Ingredient, IngredientDto>().ReverseMap();
        CreateMap<Picture, PictureDto>().ReverseMap();
    }
}