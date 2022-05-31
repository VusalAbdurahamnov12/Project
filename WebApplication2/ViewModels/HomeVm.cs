using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class HomeVm
    {
        public List<Comments> Comments { get; set; }
        public Contact Contact { get; set; }
        public List<OurSocial> OurSocials { get; set; }
        public List<Partnior> Partniors { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Slogan> Slogans { get; set; }
        public List<Statistica> Statisticas { get; set; }
        public List<Team> Teams { get; set; }
        //public Team Teamss { get; set; }
        public List<TeamSocial> TeamSocials { get; set; }
    }
}
