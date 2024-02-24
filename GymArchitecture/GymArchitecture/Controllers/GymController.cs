using GymArchitecture.Application.Services.GymService;
using GymArchitecture.Domain.Entities.DTOs;
using GymArchitecture.Domain.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymArchitecture.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GymController : ControllerBase
    {
        private readonly IGymService _gymService;

        public GymController(IGymService carService)
        {
            _gymService = carService;
        }

        [HttpPost]
        public async Task<string> CreateGym([FromForm] GymDTO model)
        {
            var result = await _gymService.CreateGymAsync(model);

            return result;
        }

        [HttpPut]
        public async Task<string> UpdateGym(int id,[FromForm] GymDTO gym)
        {
            var result = await _gymService.UpdateGymAsync(id, gym);

            return result;
        }

        [HttpDelete]
        public async Task<string> DeleteGym(int id)
        {
            var result = await _gymService.DeleteGymAsync(id);

            return result;
        }

        [HttpGet]
        public async Task<List<Gym>> GetAllGyms()
        {
            return await _gymService.GetAllGymAsync();
        }

        [HttpGet]
        public async Task<Gym> GetGymByID(int id)
        {
            return await _gymService.GetGymAsync(id);
        }
    }
}
