using RefactorAspNetWebAPI.Application.DTOs.Email;
using System.Threading.Tasks;

namespace RefactorAspNetWebAPI.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}