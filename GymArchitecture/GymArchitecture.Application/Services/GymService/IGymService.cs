using GymArchitecture.Domain.Entities.DTOs;
using GymArchitecture.Domain.Entities.Models;

namespace GymArchitecture.Application.Services.GymService
{
    public interface IGymService
    {
        public Task<string> CreateGymAsync(GymDTO gym);
        public Task<string> UpdateGymAsync(int id, GymDTO gym);
        public Task<string> DeleteGymAsync(int id);
        public Task<List<Gym>> GetAllGymAsync();
        public Task<Gym> GetGymAsync(int id);
    }
}
