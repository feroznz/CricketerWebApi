using CricketersWebApi.DAL.Entities;
using CricketersWebApi.DAL.Repositories;
using WebApplication3.DAL.Entities;

namespace CricketersWebApi.DAL
{
    public class StatsService:IStatsService
    {
        private Repository<Game> _games;
        private Repository<Team> _teams;
        private Repository<Player> _players;
        private StatsDbContext _context;
        public StatsService()
        {
            _context = new StatsDbContext();
        }
        public Repository<Game> Games
        {
            get
            {
                if (_games == null)
                    _games = new GameRepository(_context);
               
                return _games;
            }
        }

        public Repository<Team> Teams
        {
            get
            {
                if (_teams == null)
                    _teams = new TeamRepository(_context);

                return _teams;
            }
        }

        public Repository<Player> Players
        {
            get
            {
                if(_players == null)
                    _players = new PlayerRepository(_context);

                return _players;
            }
           
        }

       
    }
}