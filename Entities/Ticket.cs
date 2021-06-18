using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Color { get; set; }

        // Rel with Columns
        public int ColumnId { get; set; }
        public Column Column { get; set; }

        // Rel avec comment
        public IEnumerable<Comment> Comments { get; set; }

        // ajoute d'importance du ticket
        public int Priority { get; set; }
    }
}
