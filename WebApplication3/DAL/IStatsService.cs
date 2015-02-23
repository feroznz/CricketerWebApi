using CricketersWebApi.DAL.Entities;
using CricketersWebApi.DAL.Repositories;
using WebApplication3.DAL.Entities;

namespace CricketersWebApi.DAL
{
    public interface IStatsService
    {
        Repository<Game> Games { get;}
        Repository<Team> Teams { get;  }
        Repository<Player> Players { get;  }

    }
}
