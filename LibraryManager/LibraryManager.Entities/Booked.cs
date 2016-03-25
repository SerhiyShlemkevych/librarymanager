using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Entities
{
    //class name has to noun or adj+noun
    public class Booked
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public DateTime dateBooked { get; set; }
        public DateTime dueBooked { get; set; }
        public decimal fine { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
    }
}
