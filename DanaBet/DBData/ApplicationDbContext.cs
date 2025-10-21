using DanaBet.DBModel;
using Microsoft.EntityFrameworkCore;

namespace DanaBet.DBData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> TBL_Users { get; set; }
        public DbSet<Game> TBL_Games { get; set; }
        public DbSet<LeagueGroup> TBL_LeagueGroups { get; set; }
        public DbSet<LeagueGroupsUsers> TBL_LeagueGroupsUsers { get; set; }
        public DbSet<LeagueLevels> TBL_LeagueLevels { get; set; }
        public DbSet<League> TBL_Leagues { get; set; }
        public DbSet<LeagueScores> TBL_LeagueScores { get; set; }
        public DbSet<LeagueUser> TBL_LeagueUsers { get; set; }
    }
}
