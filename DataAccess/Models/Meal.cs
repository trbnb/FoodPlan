using System;

namespace DataAccess.Models
{
    public class Meal
    {
        public Guid Id { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
