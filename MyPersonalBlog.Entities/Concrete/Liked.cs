using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Beğenme")]
    public class Liked : IEntity
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public DateTime ArticleLikedDate { get; set; }
    }
}
