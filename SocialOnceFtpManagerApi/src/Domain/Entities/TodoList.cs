using EAProductService.Domain.Common;
using System.Collections.Generic;

namespace EAProductService.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
