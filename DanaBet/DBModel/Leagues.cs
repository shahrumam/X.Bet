namespace DanaBet.DBModel
{
    public class Leagues
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int GameId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MaxUserCount { get; set; }
        public bool IsActive { get; set; }
        public virtual Game? Games { get; set; }
    }
}
