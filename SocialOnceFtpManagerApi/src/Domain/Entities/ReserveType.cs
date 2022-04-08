
using EAProductService.Domain.Common;
using EAProductService.Domain.Enums;
using System;

namespace EAProductService.Domain.Entities
{
    public class ReserveType : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
