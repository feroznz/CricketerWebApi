using System;
using System.Collections.Generic;

namespace CricketersWebApi.Models
{
    public class GameModel
    {
        public int GameId { get; set; }
        public TeamModel AwayTeam { get; set; }
        public TeamModel HomeTeam { get; set; }

        public DateTime StartTime { get; set; }

        public string Url { get; set; }

}
}
