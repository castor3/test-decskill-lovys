using System.Collections.Generic;

namespace Decskill_Lovys_Calendar.Domain.Entities
{
    public class AvailabilityEntity
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public IEnumerable<AvailabilitySlot> Slots { get; set; }
    }
}