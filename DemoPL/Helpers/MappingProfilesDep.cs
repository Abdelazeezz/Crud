using AutoMapper;
using Demo.DAL.Model;
using Demo.PL.ViewModels;

namespace Demo.PL.Helpers
{
    public class MappingProfilesDep : Profile
    {
        public MappingProfilesDep()
        {
            CreateMap<DepartmentViewModel, Department>().ReverseMap();
        }
    }
}
