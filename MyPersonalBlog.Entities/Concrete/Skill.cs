using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Yetenekler")]
    public class Skill : IEntity
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int SkillLevel { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
