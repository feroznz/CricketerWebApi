using System.ComponentModel.DataAnnotations;

namespace CricketersWebApi.Models
{
    public class PlayerModel
    {
        public int PlayerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public string Age { get; set; }

        public string Role { get; set; }
        public string Batting { get; set; }
        public string Bowling { get; set; }
        public string ProfileUrl { get; set; }
        public string ImageUrl { get; set; }

        public string SpecialRole { get; set; }
    }
}