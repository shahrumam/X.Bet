namespace DanaBet.DBModel
{
    public class LeagueGroup
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int LevelId { get; set; }
        public virtual LeagueLevels? LeagueLevels { get; set; }
    }
}
