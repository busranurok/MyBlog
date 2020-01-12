using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Yorumlar")]
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Nick { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentCreatedDate { get; set; }
        public DateTime CommentModifiedDate { get; set; }
        public int CommentCreatedUserId { get; set; }
        public int CommentModifiedUserId { get; set; }
        public bool IsApproval { get; set; }
    }
}
