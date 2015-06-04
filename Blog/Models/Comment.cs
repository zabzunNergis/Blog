using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ArticleID { get; set; }
        public Article Article { get; set; }
    }

    public class CommentDBContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}

