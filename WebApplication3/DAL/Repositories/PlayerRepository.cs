using CricketersWebApi.DAL.Entities;
using WebApplication3.DAL;

namespace CricketersWebApi.DAL.Repositories
{
    public class PlayerRepository:Repository<Player>
    {
        public PlayerRepository(StatsDbContext context) : base(context)
        {
        }
    }
}