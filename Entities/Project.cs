using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<WorkOn> WorkOns { get; set; }

        // REL avec Col
        public IEnumerable<Column> Columns { get; set; }

    }
}
