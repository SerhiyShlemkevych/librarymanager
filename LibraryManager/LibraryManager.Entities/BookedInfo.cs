using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Entities
{
    public class BookedInfo
    {
        public int BookedId { get; set; }
        public string MemberPassport { get; set; }
        public string BookName { get; set; }
        public string DateBooked { get; set; }
        public string DueDate { get; set; }        
    }
}
