namespace DanaBet.DBModel
{
    public class LeagueGroupsUsers
    {
        public int Id { get; set; }
        public int LeagueGroupId { get; set; }
        public int UserId { get; set; }
        public virtual LeagueGroups? LeagueGroups { get; set; }
    }
}
