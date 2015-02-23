using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CricketersWebApi.Models
{
    public class TeamModel
    {
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        public string Url { get; set; }
        public List<PlayerModel> Players { get; set; }
 
    }
}