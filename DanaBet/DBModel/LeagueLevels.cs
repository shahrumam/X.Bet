namespace DanaBet.DBModel
{
    public class LeagueLevels
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int LeagueId { get; set; }
        public virtual Leagues? Leagues { get; set; }
    }
}
