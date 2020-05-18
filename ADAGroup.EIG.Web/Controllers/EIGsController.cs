using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    public class EIGsController : ControllerBase
    {
        private readonly IInterestGroupService _groupService;

        public EIGsController(IInterestGroupService groupService)
        {
            _groupService = groupService;
        }


        // GET: api/Groups
        [HttpGet]
        [ActionName("All")]
        public IEnumerable<EIGViewModel> Get()
        {
            IList<EIGViewModel> eigs = new List<EIGViewModel>();

            var dataList = _groupService.GetInterestGroups();
            foreach (var item in dataList)
            {
                eigs.Add(new EIGViewModel() { 
                    GroupId = item.Id.ToString(),
                    Name = item.Name,
                    Vision = item.Vision,
                    Mission = item.Mission,
                    About = item.About,
                    ContactPerson = item.Contacts,
                });
            }

            // sample create record
            return eigs;
        }

        [HttpPost]
        public IActionResult Upsert([FromBody] EIGViewModel eig)
        {
            if(!ModelState.IsValid)
            {
                //TODO: Return error code
            }

            try
            {
                // upsert eig record
                _groupService.UpsertInterestGroup(new InterestGroup()
                {
                    Id = string.IsNullOrEmpty(eig.GroupId) ? Guid.Empty : Guid.Parse(eig.GroupId),
                    Name = eig.Name,
                    Vision = eig.Vision,
                    Mission = eig.Mission,
                    About = eig.About,
                    Contacts = eig.ContactPerson,
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