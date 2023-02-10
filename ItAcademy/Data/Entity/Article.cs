namespace ItAcademy.Data.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int SiteId { get; set; }
        public Site Site { get; set; }
        public int PositiveIndex { get; set; }
        public int LikeCount { get; set; }
    }
}
