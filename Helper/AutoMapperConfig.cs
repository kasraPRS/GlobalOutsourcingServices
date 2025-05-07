using AutoMapper;
using GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks;
using GlobalOutsourcingServices.Services.Domain.Entities;
namespace GlobalOutsourcingServices.Helper
{
    public class ContactProfile : Profile
    {
        public ContactProfile() {
            CreateMap<TaskModel,AddTaskCommand>().ReverseMap();
        }
    }
}
