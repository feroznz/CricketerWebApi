using WebApplication3.DAL.Entities;

namespace CricketersWebApi.DAL.Entities
{
    public class Player:EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Team Team { get; set; }

        public string Age { get; set; }

        public string Role { get; set; }
        public string Batting { get; set; }
        public string Bowling { get; set; }
        public string ProfileUrl { get; set; }
        public string ImageUrl { get; set; }

        public string SpecialRole { get; set; }

      
    }
}