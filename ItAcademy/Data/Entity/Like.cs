﻿namespace ItAcademy.Data.Entity
{
    public class Like
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
