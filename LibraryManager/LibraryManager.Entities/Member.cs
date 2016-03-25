﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Entities
{
    public class Member
    {
        public string PassportId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }        
        public string DateOfMembership { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        //Deleted -> IsDeleted for bool properies
        public bool Deleted { get; set; }
    }
}