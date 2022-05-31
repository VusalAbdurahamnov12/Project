namespace WebApplication2.Models
{
    public class TeamSocial
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team{ get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
