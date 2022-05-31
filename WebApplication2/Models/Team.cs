using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Work { get; set; }
        public ICollection<TeamSocial> TeamSocials { get; set; }
    }
}
