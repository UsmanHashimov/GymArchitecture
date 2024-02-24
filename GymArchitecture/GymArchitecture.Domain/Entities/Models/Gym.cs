namespace GymArchitecture.Domain.Entities.Models
{
    public class Gym
    {
        public int id { get; set; }
        public required string? name { get; set; }
        public string? description { get; set; }
        public required string? location { get; set; }
        public required int rating { get; set; }
    }
}
