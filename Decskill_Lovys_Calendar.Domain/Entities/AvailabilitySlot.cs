using System;

namespace Decskill_Lovys_Calendar.Domain.Entities
{
    public class AvailabilitySlot
    {
        public DateTimeOffset DateStart { get; set; }
        public DateTimeOffset DateEnd { get; set; }
    }
}