﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADAGroup.EIG.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADAGroup.EIG.UI.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IInterestGroupService _groupService;

        public GroupsController(IInterestGroupService groupService)
        {
            _groupService = groupService;
        }


        // GET: api/Groups
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // sample create record
            _groupService.UpsertInterestGroup();



            return new string[] { "value1", "value2" };
        }

        // GET: api/Groups/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Groups
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Groups/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
