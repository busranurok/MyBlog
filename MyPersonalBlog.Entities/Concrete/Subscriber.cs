using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Aboneler")]
    public class Subscriber : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Guid ActiveGuid { get; set; }
    }
}
