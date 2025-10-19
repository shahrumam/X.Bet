namespace DanaBet.DBModel
{
    public class LeagueUsers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LeagueId { get; set; }
        public virtual Leagues? Leagues { get; set; }
        public virtual Users? Users { get; set; }
    }
}
