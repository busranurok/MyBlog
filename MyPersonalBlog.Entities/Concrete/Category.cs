using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Kategoriler")]
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime CategoryCreatedDate { get; set; }
        public DateTime CategoriModifiedDate { get; set; }
        public int CategoryCreatedUserId { get; set; }
        public int CategoryModifiedUserId { get; set; }
        public virtual User User { get; set; }
    }
}
