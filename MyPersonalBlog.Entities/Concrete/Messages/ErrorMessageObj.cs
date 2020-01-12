using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Concrete.Messages
{
    public class ErrorMessageObj
    {
        public ErrorMessageCode ErrorMessageCode { get; set; }
        public string Message { get; set; }
    }
}
