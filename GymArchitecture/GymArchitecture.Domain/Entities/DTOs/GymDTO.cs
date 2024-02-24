namespace GymArchitecture.Domain.Entities.DTOs
{
    public class GymDTO
    {
        public required string? name { get; set; }
        public string? description { get; set; }
        public required string? location { get; set; }
        public required int rating { get; set; }
    }
}
