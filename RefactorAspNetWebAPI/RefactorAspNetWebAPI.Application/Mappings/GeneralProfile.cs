using AutoMapper;
using RefactorAspNetWebAPI.Application.Features.Employees.Queries.GetEmployees;
using RefactorAspNetWebAPI.Application.Features.Positions.Commands.CreatePosition;
using RefactorAspNetWebAPI.Application.Features.Positions.Queries.GetPositions;
using RefactorAspNetWebAPI.Domain.Entities;

namespace RefactorAspNetWebAPI.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}