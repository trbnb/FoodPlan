using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace DataAccess.Context
{
    public class FoodPlanContext : DbContext
    {
#pragma warning disable CS8618 // Das Non-Nullable-Feld ist nicht initialisiert. Deklarieren Sie das Feld ggf. als "Nullable".
        public FoodPlanContext(DbContextOptions options) : base(options) { }
#pragma warning restore CS8618 // Das Non-Nullable-Feld ist nicht initialisiert. Deklarieren Sie das Feld ggf. als "Nullable".
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
