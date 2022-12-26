using RefactorAspNetWebAPI.Application.Interfaces;
using System;

namespace RefactorAspNetWebAPI.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}