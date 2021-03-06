using NextLevelTrainingApi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelTrainingApi.ViewModels
{
    public class CoachSummaryViewModel
    {
        public int BookingsCount { get; set; }
        public int TotalBookingsCount { get; set; }
        public int Level { get; set; }
        public List<UserDataViewModel> Players { get; set; }
        public List<BookingViewModel> Bookings { get; set; }
    }
}
