using Businesslogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Businesslogic.Repository
{
    public interface IMealRepository
    {
        IQueryable<MealDTO> GetAll();
        
        Task<IEnumerable<MealDTO>> GetAllAsync();

        Task<MealDTO?> GetByIdAsync(Guid id);
    }
}
