using Businesslogic.DTO;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Businesslogic.Repository
{
    public interface IMealRepository
    {
        public IQueryable<MealDTO> GetAll();

        public Task<MealDTO?> GetByIdAsync(Guid id);
    }
}
