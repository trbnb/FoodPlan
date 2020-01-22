using AutoMapper;
using AutoMapper.QueryableExtensions;
using Businesslogic.DTO;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Repository
{
    public class MealRepository : IMealRepository
    {
        private readonly FoodPlanContext foodPlanContext;
        private readonly IMapper mapper;

        public MealRepository(FoodPlanContext foodPlanContext, IMapper mapper)
        {
            this.foodPlanContext = foodPlanContext;
            this.mapper = mapper;
        }

        public IQueryable<MealDTO> GetAll() => foodPlanContext.Meals.AsQueryable().ProjectTo<MealDTO>();

        public async Task<MealDTO?> GetByIdAsync(Guid id)
        {
            return mapper.Map<MealDTO?>(await foodPlanContext.Meals.FindAsync(id));
        }
    }
}
