namespace DanaBet.DBModel
{
    public class LeagueGroupsUsers
    {
        public int Id { get; set; }
        public int LeagueGroupId { get; set; }
        public int LeagueUserId { get; set; }
        public virtual LeagueGroup? LeagueGroups { get; set; }
        public LeagueUser? LeagueUser { get; set; }
    }
}
