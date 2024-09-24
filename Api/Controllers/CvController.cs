using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("cv")]
public class CvController : ControllerBase
{
	[HttpGet("generate")]
	public ActionResult<CvDto> Generate()
	{
		return Ok(new CvDto()
		{
			Data = "oihduasqigdilusgdilasglidgausigdqgtepdqwqwhg9oqwgho9shyayhdyhp;o912",
		});
	}

	[HttpPost("upload")]
	public ActionResult Upload(CvDto cv)
	{
		return Ok();
	}
}

public class CvDto
{
	public required string Data { get; set; }
}
