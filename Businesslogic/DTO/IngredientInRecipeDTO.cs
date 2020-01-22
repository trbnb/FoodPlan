using System;
using System.Collections.Generic;
using System.Text;

namespace Businesslogic.DTO
{
    public class IngredientInRecipeDTO
    {
        public Guid ID { get; set; }
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        public IngredientMeasureDTO? Measure { get; set; }
    }
}
