using System.Collections.Generic;

namespace CricketersWebApi.DAL.Entities
{
    public class Team : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Player> Players  { get; set; }
    }
}