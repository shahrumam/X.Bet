namespace DanaBet.DBModel
{
    public class LeagueScores
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int LeagueGroupUserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MaxUserCount { get; set; }
        public bool IsActive { get; set; }
        public virtual LeagueGroupsUsers? LeagueGroupsUsers { get; set; }
    }
}
