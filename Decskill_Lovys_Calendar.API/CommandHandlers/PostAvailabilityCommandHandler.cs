using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Decskill_Lovys_Calendar.API.Commands;
using Decskill_Lovys_Calendar.Domain.Entities;
using Decskill_Lovys_Calendar.Domain.Repositories;
using MediatR;

namespace Decskill_Lovys_Calendar.API.CommandHandlers
{
    public class PostAvailabilityCommandHandler : IRequestHandler<PostAvailabilityCommand>
    {
        private readonly IAvailabilityRepository _availabilityRepository;
        private readonly IMapper _mapper;

        public PostAvailabilityCommandHandler(IAvailabilityRepository availabilityRepository, IMapper mapper)
        {
            _availabilityRepository = availabilityRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(PostAvailabilityCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<AvailabilityEntity>(request.Request);

            _availabilityRepository.Save(entity);

            return Task.FromResult(Unit.Value);
        }
    }
}