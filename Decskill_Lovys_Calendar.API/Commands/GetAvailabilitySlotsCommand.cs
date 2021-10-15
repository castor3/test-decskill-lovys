using System.Collections.Generic;
using Decskill_Lovys_Calendar.API.ViewModels;
using MediatR;

namespace Decskill_Lovys_Calendar.API.Commands
{
    public class GetAvailabilitySlotsCommand : IRequest<IEnumerable<AvailabilitySlot>>
    {
        public GetAvailabilitySlotsCommand(GetAvailabilitySlotsRequest request)
        {
            Request = request;
        }

        public GetAvailabilitySlotsRequest Request { get; }
    }
}