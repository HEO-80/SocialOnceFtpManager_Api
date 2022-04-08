using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Entities
{
    public class File
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public string Route { get; set; }

        public bool isPublic { get; set; }

        public bool isPrivate { get; set; }

        public bool Connection { get; set; }

        public bool Send { get; set; }

        public List<File> Packages { get; set; }

        public string Status { get; set; }
    }
}
