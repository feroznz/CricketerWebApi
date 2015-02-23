using CricketersWebApi.DAL.Entities;
using WebApplication3.DAL;

namespace CricketersWebApi.DAL.Repositories
{
    public class TeamRepository:Repository<Team>
    {
        public TeamRepository(StatsDbContext context) : base(context)
        {
        }
    }
}