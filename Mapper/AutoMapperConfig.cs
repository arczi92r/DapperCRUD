using AutoMapper;
using DataTransferObject;
using Domain;

namespace Mapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
           => new MapperConfiguration(cfg =>
           {

               cfg.CreateMap<Role, RoleDTO>();
               cfg.CreateMap<Field, FiedDTO>();
             
           })
           .CreateMapper();
    }
}
