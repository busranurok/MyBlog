using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete
{
    [Table("Sertifikalar")]
    public class Certificate : IEntity
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public string CertificateReceived { get; set; }
        public DateTime DateOfReceiptOfCertificate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
