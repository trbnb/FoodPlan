using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class IngredientInRecipe
    {
        public Guid ID { get; set; }
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        public IngredientMeasure Measure { get; set; }
    }
}
