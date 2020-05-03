using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class EntityBase: AuditableEntity
    {
        public Guid Id { get; set; }
    }
}
