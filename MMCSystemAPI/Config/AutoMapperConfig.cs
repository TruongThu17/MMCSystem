using AutoMapper;
using Data.DTO;
using Data.Models;

namespace MMCSystemAPI.Config
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<User, StudentProfileDTO>();
                config.CreateMap<StudentProfileDTO, User>();


                config.CreateMap<About, AboutDTO>();
                config.CreateMap<AboutDTO, About>();

                config.CreateMap<Blog, BlogDTO>();
                config.CreateMap<BlogDTO, Blog>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}
