using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OnBoardingAPI.Data;
using OnBoardingAPI.Dtos;
using OnBoardingAPI.Models;

namespace OnBoardingAPI.Controllers
{
   [Route("api/summaryDetails")]
   [ApiController]
   public class SummaryController : ControllerBase
   {
        private readonly ISummary  _repository;

        public SummaryController(ISummary repository)
        {
            _repository = repository;
        }

        [HttpGet("{employeeId}", Name="GetSummaryDetailsByEmployeeId")]
        public ActionResult GetSummaryDetailsByEmployeeId(int employeeId)
        {
            var personaldetailsItems = _repository.GetDetailsSummary(employeeId);

            return Ok(personaldetailsItems);
        }
   }
}