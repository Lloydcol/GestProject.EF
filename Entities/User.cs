using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        public string Role { get; set; }

        [Required]
        public byte[] Passwd { get; set; }

        [Required]
        public Guid Salt { get; set; }

        public virtual IEnumerable<WorkOn> WorkOns { get; set; }
    }
}
