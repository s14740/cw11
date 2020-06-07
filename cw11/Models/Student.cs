using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Student : Person
    {
        public string IndexNumber { get; set; }

        [ForeignKey("Subject")]
        public int? IdSubject { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
