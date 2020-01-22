using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Url { get; set; }
    }
}
