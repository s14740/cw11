using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSubject { get; set; }

        [Required]
        public string Name { get; set; }

        public int? TotalPoints { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
