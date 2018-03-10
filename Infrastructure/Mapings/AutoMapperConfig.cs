using AutoMapper;
using Entity;
using Model;

namespace Infrastructure.Mapings
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
               
                cfg.CreateMap<Person, PersonViewModel>();
                //cfg.CreateMap<Ticket, TicketDto>();
                //cfg.CreateMap<Ticket, TicketDetailsDto>();
                //cfg.CreateMap<User, AccountDto>();
            })
            .CreateMapper();
    }
}
