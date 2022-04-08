using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Entities
{
    public class Log
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public DateTime DateAction { get; set; }
        public DateTime DateModify { get; set; }
        public string   TypeModify { get; set; }

        public int WhoModifyId { get; set; }

        public string WhoModifyName { get; set; }




    }
}
