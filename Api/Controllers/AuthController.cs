using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
	[HttpGet("login")]
	public ActionResult Login()
	{
		return Ok();
	}
}