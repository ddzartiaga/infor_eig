using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Service.Contracts;
using ADAGroup.EIG.WebUI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ADAGroup.EIG.WebUI.Controllers
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
        [ActionName("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hi!");
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

                return Ok(new GroupInfo()
                {
                    GroupId = details.Id.ToString(),
                    Name = details.Name,
                    LogoFileName = details.LogoFileName,
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
        [ActionName("NewGroup")]
        public IActionResult NewGroup([FromBody] GroupInfo group)
        {

            try
            {
                var gId = UpsertGroup(group);
                return Ok(gId);
            }
            catch (Exception ex)
            {
                //TODO: Return error code
                return BadRequest();
            }
        }

        [HttpPut]
        [ActionName("UpdateGroup")]
        public IActionResult UpdateGroup([FromBody] GroupInfo group)
        {
            try
            {
                var gId = UpsertGroup(group);
                return Ok(gId);
            }
            catch (Exception ex)
            {
                //TODO: Return error code
                return BadRequest();
            }

        }

        private Guid UpsertGroup(GroupInfo group)
        {
            // upsert eig record
            return _groupService.UpsertInterestGroup(new InterestGroup()
            {
                Id = string.IsNullOrEmpty(group.GroupId) ? Guid.Empty : Guid.Parse(group.GroupId),
                Name = group.Name,
                LogoFileName = group.LogoFileName,
                GoalAndPurpose = group.GoalAndPurpose,
                Mission = group.Mission,
            });
        }
    }
}