using System;
using Microsoft.AspNetCore.Mvc;

namespace Hangfire.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeController : ControllerBase
{
    [HttpGet("GetTimeNow")]
    public IActionResult Get()
    {
        return Ok(DateTime.Now);
    }
}