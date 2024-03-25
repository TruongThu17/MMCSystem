using AutoMapper;
using Data.DTO;
using Data.Models;
using DataAccess;

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

                config.CreateMap<MealPlan, MealPLanDTO>();
                config.CreateMap<MealPLanDTO, MealPlan>();

                config.CreateMap<MealPlanDetail, MealPlanDetailDTO>();
                config.CreateMap<MealPlanDetailDTO, MealPlanDetail>();

                config.CreateMap<Dish, DishDTO>();
                config.CreateMap<DishDTO, Dish>();

                config.CreateMap<Supplier, SupplierDTO>();
                config.CreateMap<SupplierDTO, Supplier>();

                config.CreateMap<Ingredient, IngredientDTO>();
                config.CreateMap<IngredientDTO, Ingredient>();

                config.CreateMap<Order, OrderDTO>();
                config.CreateMap<OrderDTO, Order>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}
