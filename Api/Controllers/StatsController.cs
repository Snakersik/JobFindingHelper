using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("stats")]
public class StatsController : ControllerBase
{
	[HttpGet]
	public ActionResult<StatsDto> Get()
	{
		return Ok(new StatsDto()
		{
			All = 200,
			AutomaticResponse = 12,
			HumanResponse = 1,
			SucceededResponse = 0,
			AwaitingResponse = 187
		});
	}
}

public class StatsDto
{
	public int All { get; set; }
	public int AutomaticResponse { get; set; }
	public int HumanResponse { get; set; }
	public int FailedResponse { get; set; }
	public int SucceededResponse { get; set; }
	public int AwaitingResponse { get; set; }
}
