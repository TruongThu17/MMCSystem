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

            });

            return mapperConfig.CreateMapper();
        }
    }
}
