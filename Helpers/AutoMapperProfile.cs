using TokenWebAPI.Models;
using AutoMapper;
using TokenWebAPI.DTOs;
using System.Text;

namespace TokenWebAPI.Helpers
{
    public class AutoMapperProfile: Profile
    {
       public AutoMapperProfile()
        {
            //CreateMap<TblBook, BookListDto>();
            CreateMap<LoginDto, TblUser>();
            CreateMap<RegisterDto, TblUser>()

           // .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
           // .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => Encoding.Unicode.GetBytes( src.Password)));

        }
    }
}
