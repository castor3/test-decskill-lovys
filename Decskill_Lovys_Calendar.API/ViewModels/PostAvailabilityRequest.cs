using System.Collections.Generic;

namespace Decskill_Lovys_Calendar.API.ViewModels
{
    public class PostAvailabilityRequest
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public IEnumerable<AvailabilitySlot> Slots { get; set; }
    }
}