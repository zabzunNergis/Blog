using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class ArticleCommentViewModel
    {
        public Article Article { set; get; }
        public List<Comment> Comment { set; get; }

        public ArticleCommentViewModel(int articleid) 
        {
            var db = new ArticleDBContext();
            var db2 = new CommentDBContext();

            Article = db.Articles.First(x => x.ID == articleid);

            var query = from x in db2.Comments where x.ArticleID == articleid select x;

            Comment = query.ToList();
        
        }
    }
}