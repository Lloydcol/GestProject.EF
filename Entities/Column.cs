using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Entities
{
    public class Column
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AccessibleBy { get; set; }

        // REL AVEC PROJ
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        // Rel avec ticket
        public IEnumerable<Ticket> Tickets { get; set; }

        //Ordre des cols
        public int Position { get; set; }
    }
}
