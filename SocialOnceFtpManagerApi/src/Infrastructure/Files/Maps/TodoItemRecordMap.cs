using CsvHelper.Configuration;
using EAProductService.Application.TodoLists.Queries.ExportTodos;
using System.Globalization;

namespace EAProductService.Infrastructure.Files.Maps
{
    public class TodoItemRecordMap : ClassMap<TodoItemRecord>
    {
        public TodoItemRecordMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
        }
    }
}
