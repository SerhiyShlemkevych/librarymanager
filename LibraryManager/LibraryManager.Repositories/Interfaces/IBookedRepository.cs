using System;
using System.Collections.Generic;
using LibraryManager.Entities;

namespace LibraryManager.Repositories
{
    public interface IBookedRepository
    {
        IEnumerable<BookedInfo> SelectInfo(string filterName, string FilterValue);        
        void AddBooked(Booked bookedToAdd);
        void DeleteBooked(Booked bookedToDelete);
        Booked GetBookedById(int Id);
        void SetBookedFine(Booked booked);
    }
}
