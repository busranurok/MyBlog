using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Makaleler")]
    public class Article : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public bool IsDraft { get; set; }
        public DateTime ArticleCreatedDate { get; set; }
        public DateTime ArticleModifiedDate { get; set; }
        public int ArticleCreatedUserId { get; set; }
        public int ArticleModifiedUserId { get; set; }
        public virtual User User { get; set; }
        public string ImageURL { get; set; }
    }
}
