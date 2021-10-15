using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decskill_Lovys_Calendar.API.Commands;
using Decskill_Lovys_Calendar.API.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Decskill_Lovys_Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvailabilityController : ControllerBase
    {
        private readonly ILogger<AvailabilityController> _logger;
        private readonly IMediator _mediatr;

        public AvailabilityController(
            ILogger<AvailabilityController> logger,
            IMediator mediatr)
        {
            _logger = logger;
            _mediatr = mediatr;
        }

        [HttpPost]
        public async Task<IActionResult> DefinePersonAvailability(PostAvailabilityRequest request)
        {
            var postAvailabilityCommand = new PostAvailabilityCommand(request);

            await _mediatr.Send(postAvailabilityCommand);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAvailabilitySlots(
            [FromBody] GetAvailabilitySlotsRequest request)
        {
            var getAvailabilitySlotsCommand = new GetAvailabilitySlotsCommand(request);

            IEnumerable<AvailabilitySlot> availabilitySlots;
            try
            {
                availabilitySlots = await _mediatr.Send(getAvailabilitySlotsCommand);
            }
            catch (Exception e) // Should be changed to something like CandidateNotFoundException
            {
                return BadRequest($"Candidate with name: {request.CandidateName} not found.");
            }

            if (!availabilitySlots.Any())
            {
                return NotFound("No slots available");
            }

            return Ok(availabilitySlots);
        }
    }
}