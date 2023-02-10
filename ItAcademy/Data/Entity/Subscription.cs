namespace ItAcademy.Data.Entity
{
    public class Subscription
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public Site Site { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
