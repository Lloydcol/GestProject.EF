using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }

        // Rel with Columns
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
