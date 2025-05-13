using Microsoft.AspNetCore.Mvc;
using WebApiDock.Services.Interfaces;

namespace WebApiDock.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
  private readonly IUserService _userService;

  public UserController(IUserService userService)
  {
    _userService = userService;
  }

  [HttpGet]
  public async Task<IActionResult> Get()
  {
    var users = await _userService.GetAsync();
    return Ok(users);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(int id)
  {
    var user = await _userService.GetByIdAsync(id);
    return Ok(user);
  }
}
