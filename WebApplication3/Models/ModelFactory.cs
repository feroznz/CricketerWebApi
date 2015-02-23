using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Routing;
using CricketersWebApi.DAL.Entities;
using WebApplication3.DAL.Entities;

namespace CricketersWebApi.Models
{
    public interface IModelFactory
    {
        PlayerModel Create(Player player);
        Player Create(PlayerModel playerModel);
        Player Create(PlayerModel playerModel, Team team);


        TeamModel Create(Team team);
        Team Create(TeamModel teamModel);

        GameModel Create(Game game);


        GameEvent Create(Game gameEntity, Player playerEntity, int pointValue);

        
    }

    public class ModelFactory : IModelFactory
    {
        private readonly UrlHelper _urlHelper;

        public ModelFactory(HttpRequestMessage message)
        {
            _urlHelper = new UrlHelper(message);
        }
        public PlayerModel Create(Player player)
        {
            return new PlayerModel
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PlayerId = player.ID,
                TeamId = player.Team != null ? player.Team.ID : 0,
                TeamName = player.Team != null ? player.Team.Name : null,
                Age = player.Age,
                Batting = player.Batting,
                Bowling = player.Bowling,
                ImageUrl = player.ImageUrl,
                ProfileUrl = player.ProfileUrl,
                SpecialRole =player.SpecialRole,
                Role = player.Role,
            };
        }

        public Player Create(PlayerModel playerModel)
        {
            if (playerModel.PlayerId == 0)
            {
                return new Player
                {
                    FirstName = playerModel.FirstName,
                    LastName = playerModel.LastName,
                    UpdatedDate = DateTime.Now,
                    Age = playerModel.Age,
                    Batting = playerModel.Batting,
                    Bowling = playerModel.Bowling,
                    ImageUrl = playerModel.ImageUrl,
                    ProfileUrl = playerModel.ProfileUrl,
                    SpecialRole = playerModel.SpecialRole,
                    Role = playerModel.Role
                };
            }

            return new Player
            {
                ID = playerModel.PlayerId,
                FirstName = playerModel.FirstName,
                LastName = playerModel.LastName,
                UpdatedDate = DateTime.Now,
                Age = playerModel.Age,
                Batting = playerModel.Batting,
                Bowling = playerModel.Bowling,
                ImageUrl = playerModel.ImageUrl,
                ProfileUrl = playerModel.ProfileUrl,
                SpecialRole = playerModel.SpecialRole,
                Role = playerModel.Role
            };
        }

        public Player Create(PlayerModel playerModel,Team team)
        {
            if (playerModel.PlayerId == 0)
            {
                return new Player
                {
                    FirstName = playerModel.FirstName,
                    LastName = playerModel.LastName,
                    UpdatedDate = DateTime.Now,
                    Team = team,
                    Age = playerModel.Age,
                    Batting = playerModel.Batting,
                    Bowling = playerModel.Bowling,
                    ImageUrl = playerModel.ImageUrl,
                    ProfileUrl = playerModel.ProfileUrl,
                    SpecialRole = playerModel.SpecialRole,
                    Role = playerModel.Role
                };
            }

            return new Player
            {
                ID = playerModel.PlayerId,
                FirstName = playerModel.FirstName,
                LastName = playerModel.LastName,
                UpdatedDate = DateTime.Now,
                Age = playerModel.Age,
                Batting = playerModel.Batting,
                Bowling = playerModel.Bowling,
                ImageUrl = playerModel.ImageUrl,
                ProfileUrl = playerModel.ProfileUrl,
                SpecialRole = playerModel.SpecialRole,
                Role = playerModel.Role
            };
        }

        public TeamModel Create(Team team)
        {
            return new TeamModel
            {
                TeamId = team.ID,
                TeamName = team.Name,
                Players = new List<PlayerModel>(team.Players.Select(Create)),
                Url = _urlHelper.Link("DefaultApi", new { id = team.ID })
            };
        }

        public Team Create(TeamModel teamModel)
        {
            if (teamModel.TeamId == 0)
            {
                return new Team
                {
                    Name = teamModel.TeamName,
                    Players = new List<Player>(teamModel.Players.Select(Create)),
                    UpdatedDate = DateTime.Now
                };
            }

            return new Team
            {
                ID = teamModel.TeamId,
                Name = teamModel.TeamName,
                Players = new List<Player>(teamModel.Players.Select(Create)),
                UpdatedDate = DateTime.Now
            };
        }

        public GameModel Create(Game game)
        {
            return new GameModel
            {
                AwayTeam = Create(game.AwayTeam),
                HomeTeam = Create(game.HomeTeam),
                GameId = game.ID,
                StartTime = game.StartTime

            };
        }


        public GameEvent Create(Game gameEntity, Player playerEntity, int pointValue)
        {
            return new GameEvent
            {
                Game = gameEntity,
                Player = playerEntity,
                PointValue = pointValue,
                UpdatedDate = DateTime.Now
            };
        }
    }
}