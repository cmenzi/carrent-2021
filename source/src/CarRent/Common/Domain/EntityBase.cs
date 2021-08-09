namespace CarRent.Common.Domain
{
    using System;

    public abstract class EntityBase
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
