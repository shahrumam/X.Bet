using DanaBet.DBModel;
using Microsoft.EntityFrameworkCore;

namespace DanaBet.Applications
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Users>             TBL_Users { get; set; }
        public DbSet<Game>             TBL_Games { get; set; }
        public DbSet<LeagueGroups>      TBL_LeagueGroups { get; set; }
        public DbSet<LeagueGroupsUsers> TBL_LeagueGroupsUsers { get; set; }
        public DbSet<LeagueLevels>      TBL_LeagueLevels { get; set; }
        public DbSet<Leagues>           TBL_Leagues { get; set; }
        public DbSet<LeagueScores>      TBL_LeagueScores { get; set; }
        public DbSet<LeagueUsers>       TBL_LeagueUsers { get; set; }
    }
}
