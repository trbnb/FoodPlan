using System;
using System.Collections.Generic;
using System.Text;

namespace Businesslogic.DTO
{
    public class RecipeDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Url { get; set; }
    }
}
