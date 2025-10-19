using System.ComponentModel.DataAnnotations;

namespace DanaBet.DBModel
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Version { get; set; }
        public bool IsActive { get; set; }
    }
}
