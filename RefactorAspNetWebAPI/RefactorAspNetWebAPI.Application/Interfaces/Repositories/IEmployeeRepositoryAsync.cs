using RefactorAspNetWebAPI.Application.Features.Employees.Queries.GetEmployees;
using RefactorAspNetWebAPI.Application.Parameters;
using RefactorAspNetWebAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefactorAspNetWebAPI.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}