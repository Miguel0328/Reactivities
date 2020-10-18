using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Followers;
using Application.Profiles;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProfilesController : BaseController
    {
        [HttpGet("{username}")]
        public async Task<ActionResult<Profile>> Get(string username) => await Mediator.Send(new Details.Query { Username = username });

        [HttpPut]
        public async Task<ActionResult<Unit>> Edit(Edit.Command command) => await Mediator.Send(command);

        [HttpGet("{username}/follow")]
        public async Task<ActionResult<List<Profile>>> GetFollowings(string username, string predicate)
            => await Mediator.Send(new List.Query { Username = username, Predicate = predicate });
    }
}
