using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Businesslogic.DTO;
using Businesslogic.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodPlanWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {
        private readonly IMealRepository mealRepository;
        public MealController(IMealRepository mealRepository) : base() 
        {
            this.mealRepository = mealRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync() 
        {
            try 
            {
                return Ok(await mealRepository.GetAllAsync());
            } 
            catch (Exception ex)
            {
                return new JsonResult(new { Error = ex.Message })
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                var item = await mealRepository.GetByIdAsync(id);
                if (item == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(item);
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Error = ex.Message })
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }
    }
}
