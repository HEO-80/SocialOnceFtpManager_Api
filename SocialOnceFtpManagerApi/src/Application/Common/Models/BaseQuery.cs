using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Application.Common.Models
{
    public class BaseQuery
    {
        public int? Skip { get; set; } = 0;
        public int? Take { get; set; } = 10;
        public string Sort { get; set; }
    }
}
