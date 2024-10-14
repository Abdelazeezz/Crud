using AutoMapper;
using Demo.DAL.Model;
using Demo.PL.ViewModels;
using DemoPL.ViewModels;

namespace DemoPL.Helpers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }

    }
}
