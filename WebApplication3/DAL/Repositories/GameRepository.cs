using CricketersWebApi.DAL.Entities;
using WebApplication3.DAL;

namespace CricketersWebApi.DAL.Repositories
{
    public class GameRepository:Repository<Game>
    {
        public GameRepository(StatsDbContext context) : base(context)
        {
        }
    }
}