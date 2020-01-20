using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private readonly FoodPlanContext _foodPlanContext;
        public MealController(FoodPlanContext foodPlanContext) : base() 
        {
            this._foodPlanContext = foodPlanContext;
        }

        [HttpGet]
        public IEnumerable<Meal> Get()
        {
            return _foodPlanContext.Meals.ToList();
        }
    }
}
