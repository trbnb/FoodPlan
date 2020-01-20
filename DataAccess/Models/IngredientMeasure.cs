using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    [Owned]
    public class IngredientMeasure
    {
        public double Amount { get; set; }
        public string Unit { get; set; }
    }
}
