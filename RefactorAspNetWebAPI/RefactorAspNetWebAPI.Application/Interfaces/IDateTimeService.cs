using System;

namespace RefactorAspNetWebAPI.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}