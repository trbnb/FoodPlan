using AutoMapper;
using AutoMapper.QueryableExtensions;
using Businesslogic.DTO;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<MealDTO> GetAll() 
        {
            var queryable = foodPlanContext.Meals.AsQueryable();
            return mapper.ProjectTo<MealDTO>(queryable);
        }

        public async Task<IEnumerable<MealDTO>> GetAllAsync() 
        {
            return await GetAll().ToListAsync();
        }

        public async Task<MealDTO?> GetByIdAsync(Guid id)
        {
            return mapper.Map<MealDTO?>(await foodPlanContext.Meals.FindAsync(id));
        }
    }
}
