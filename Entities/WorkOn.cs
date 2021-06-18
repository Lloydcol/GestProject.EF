using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Entities
{
    public class WorkOn
    {
        public int Id { get; set; }
        public string UserRole { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
