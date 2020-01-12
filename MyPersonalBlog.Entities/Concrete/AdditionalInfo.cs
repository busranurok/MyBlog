using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Ek Bilgiler")]
    public class AdditionalInfo : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Content { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
