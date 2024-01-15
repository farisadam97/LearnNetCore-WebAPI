using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.DTOs
{
    public class ProductPostDto
    {
        public string? Name { get; set; }

        public bool IsAvailable { get; set; }
        public string? Category { get; set; }
    }
}
