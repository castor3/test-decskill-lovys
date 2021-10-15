using System;

namespace Decskill_Lovys_Calendar.API.ViewModels
{
    public class AvailabilitySlot
    {
        public DateTimeOffset DateStart { get; set; }
        public DateTimeOffset DateEnd { get; set; }
    }
}