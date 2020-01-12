using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Seminerler")]
    public class Seminar : IEntity
    {
        public int Id { get; set; }
        public string SeminarName { get; set; }
        public DateTime TakenSeminarDate { get; set; }
        public string TakenInstitution { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
