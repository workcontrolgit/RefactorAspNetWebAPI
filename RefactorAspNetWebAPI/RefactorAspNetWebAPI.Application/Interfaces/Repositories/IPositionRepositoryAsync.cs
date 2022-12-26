using RefactorAspNetWebAPI.Application.Features.Positions.Queries.GetPositions;
using RefactorAspNetWebAPI.Application.Parameters;
using RefactorAspNetWebAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefactorAspNetWebAPI.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}