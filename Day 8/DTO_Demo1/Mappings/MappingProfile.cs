using AutoMapper;
using DTO_Demo1.DTO;
using DTO_Demo1.Models;

namespace DTO_Demo1.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book,BookDTO>().ReverseMap();
        }
    }
}
