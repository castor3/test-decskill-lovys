using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Decskill_Lovys_Calendar.API.Commands;
using Decskill_Lovys_Calendar.Domain.Entities;
using Decskill_Lovys_Calendar.Domain.Repositories;
using MediatR;
using AvailabilitySlot = Decskill_Lovys_Calendar.API.ViewModels.AvailabilitySlot;

namespace Decskill_Lovys_Calendar.API.CommandHandlers
{
    public class GetAvailabilitySlotsCommandHandler : IRequestHandler<GetAvailabilitySlotsCommand, IEnumerable<AvailabilitySlot>>
    {
        private readonly IAvailabilityRepository _availabilityRepository;
        private readonly IMapper _mapper;

        public GetAvailabilitySlotsCommandHandler(IAvailabilityRepository availabilityRepository, IMapper mapper)
        {
            _availabilityRepository = availabilityRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<AvailabilitySlot>> Handle(GetAvailabilitySlotsCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<AvailabilityEntity>(request.Request);

            _availabilityRepository.Get(entity);

            return Task.FromResult(Unit.Value);
        }
    }
}