using System;
using System.Collections.Generic;
using System.Text;

namespace Businesslogic.DTO
{
    public class MealDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public RecipeDTO? Recipe { get; set; }
        public string? ImageUrl { get; set; }
    }
}
