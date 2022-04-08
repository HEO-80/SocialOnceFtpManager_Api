using EAProductService.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace EAProductService.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
