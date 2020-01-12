using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Eğitim Bilgileri")]
    public class Education : IEntity
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string CountryOfSchool{ get; set; }
        public string CityOfSchool { get; set; }
        public float DiplomaScore { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsContinue { get; set; }
        public string LevelOfEducation { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
