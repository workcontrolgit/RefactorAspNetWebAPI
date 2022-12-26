using RefactorAspNetWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace RefactorAspNetWebAPI.Application.Interfaces
{
    public interface IMockService
    {
        List<Position> GetPositions(int rowCount);

        List<Employee> GetEmployees(int rowCount);

        List<Position> SeedPositions(int rowCount);
    }
}