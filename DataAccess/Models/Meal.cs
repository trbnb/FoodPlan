using System;

namespace DataAccess.Models
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Recipe? Recipe { get; set; }
        public string? ImageUrl { get; set; }
    }
}
