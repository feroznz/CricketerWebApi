using System.Data.Entity;
using CricketersWebApi.DAL.Entities;
using WebApplication3.DAL.Entities;

namespace CricketersWebApi.DAL
{
    public class StatsDbContext:DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}