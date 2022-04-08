using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Entities
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateModified { get; set; }

        public int Size { get; set; }


    }
}
