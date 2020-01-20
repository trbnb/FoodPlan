using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? EAN { get; set; }
        public string? ImageUrl { get; set; }
    }
}
