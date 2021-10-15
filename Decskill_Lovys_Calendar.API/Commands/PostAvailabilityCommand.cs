using Decskill_Lovys_Calendar.API.ViewModels;
using MediatR;

namespace Decskill_Lovys_Calendar.API.Commands
{
    public class PostAvailabilityCommand : IRequest
    {
        public PostAvailabilityCommand(PostAvailabilityRequest request)
        {
            Request = request;
        }

        public PostAvailabilityRequest Request { get; }
    }
}