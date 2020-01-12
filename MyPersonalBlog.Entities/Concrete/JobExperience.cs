using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("İş Tecrübesi")]
    public class JobExperience : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string WorkedCountry { get; set; }
        public string WorkedCity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsContinue { get; set; }
        public bool TheWorkDone { get; set; }
        public string Position { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string WorkDescription { get; set; }
    }
}
