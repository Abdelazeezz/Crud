using AutoMapper;
using Demo.DAL.Model;
using DemoPL.ViewModels;
namespace DemoPL.Helpers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();   
                //.ForMember(d=>d.Name,O=> O.MapFrom(S=> S.EmpName));  
        }

    }
}
