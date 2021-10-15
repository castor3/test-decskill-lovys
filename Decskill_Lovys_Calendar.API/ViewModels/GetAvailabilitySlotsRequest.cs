using Microsoft.AspNetCore.Mvc;

namespace Decskill_Lovys_Calendar.API.ViewModels
{
    public class GetAvailabilitySlotsRequest
    {
        public string CandidateName { get; set; }

        [FromQuery(Name = "interviewer")]
        public string[] Interviewers { get; set; }
    }
}