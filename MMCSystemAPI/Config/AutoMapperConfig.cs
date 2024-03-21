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

                config.CreateMap<User, AccountAdminDTO>();
                config.CreateMap<AccountAdminDTO, User>();

                config.CreateMap<User, AccountStudentDTO>();
                config.CreateMap<AccountStudentDTO, User>();


                config.CreateMap<About, AboutDTO>();
                config.CreateMap<AboutDTO, About>();

                config.CreateMap<Blog, BlogDTO>();
                config.CreateMap<BlogDTO, Blog>();

				config.CreateMap<Education, EducationDTO>();
				config.CreateMap<EducationDTO, Education>();

                config.CreateMap<ClassType, ClassTypeDTO>();
                config.CreateMap<ClassTypeDTO, ClassType>();

                config.CreateMap<Class, ClassDTO>();
                config.CreateMap<ClassDTO, Class>();

                config.CreateMap<MealType, MealTypeDTO>();
                config.CreateMap<MealTypeDTO, MealType>();

                config.CreateMap<Dish, DishDTO>();
                config.CreateMap<DishDTO, Dish>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}
