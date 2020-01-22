using System;
using System.Collections.Generic;
using System.Text;

namespace Businesslogic.DTO
{
    public class IngredientDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? EAN { get; set; }
        public string? ImageUrl { get; set; }
    }
}
