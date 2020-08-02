using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Service.Contracts;
using ADAGroup.EIG.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;

namespace ADAGroup.EIG.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IInterestGroupService _groupService;

        public GroupsController(IInterestGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet]
        [ActionName("GroupsList")]
        public IActionResult GroupsList()
        {
            try
            {
                var infos = _groupService.GetGroupsShortInfo();
                return Ok(infos);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [ActionName("Details")]
        public IActionResult Details(string groupId)
        {
            if (string.IsNullOrEmpty(groupId))
                return NotFound("Record not existing");

            try
            {
                var details = _groupService.GetGroupDetails(groupId);

                return Ok(new GroupDetailsVM()
                {
                    GroupId = details.Id.ToString(),
                    Name = details.Name,
                    GoalAndPurpose = details.GoalAndPurpose,
                    Mission = details.Mission,
                });
            }
            catch (Exception ex)
            {
                return BadRequest("Server Failed. " + ex.ToString());
            }
        }

        [HttpPost]
        [ActionName("Upsert")]
        public IActionResult Upsert([FromBody] GroupDetailsVM eig)
        {
            try
            {
                // upsert eig record
                _groupService.UpsertInterestGroup(new InterestGroup()
                {
                    Id = string.IsNullOrEmpty(eig.GroupId) ? Guid.Empty : Guid.Parse(eig.GroupId),
                    Name = eig.Name,
                    GoalAndPurpose = eig.GoalAndPurpose,
                    Mission = eig.Mission,
                });

                return Ok();
            }
            catch (Exception ex)
            {
                //TODO: Return error code
                return BadRequest();
            }

        }
    }
}