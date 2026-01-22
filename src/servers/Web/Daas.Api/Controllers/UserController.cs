using Daas.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Daas.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _mediator.Send(new GetUsersQuery());
        return Ok(users);
    }
}
