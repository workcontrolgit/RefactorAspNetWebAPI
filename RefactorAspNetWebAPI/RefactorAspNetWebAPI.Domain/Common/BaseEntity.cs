using System;

namespace RefactorAspNetWebAPI.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}