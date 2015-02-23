using System;
using System.Collections.Generic;
using WebApplication3.DAL.Entities;

namespace CricketersWebApi.DAL.Entities
{
    public class Game:EntityBase
    {
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public DateTime StartTime { get; set; }

        //navigation
        public virtual ICollection<GameEvent> Events { get; set; } 
    }
}