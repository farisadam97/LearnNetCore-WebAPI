using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.DTOs
{
    public class ProductDto
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public bool IsAvailable { get; set; }
        public string? Category { get; set; }
    }
}
