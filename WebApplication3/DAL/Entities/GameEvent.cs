using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CricketersWebApi.DAL.Entities;

namespace WebApplication3.DAL.Entities
{
    public class GameEvent:EntityBase
    {
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
        public virtual int PointValue { get; set; }
        
    }
}