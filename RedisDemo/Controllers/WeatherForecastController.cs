using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace RedisDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConnectionMultiplexer _redis;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConnectionMultiplexer redis)
        {
            _logger = logger;
            _redis = redis;
        }

        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            var db = _redis.GetDatabase();
            var data = await db.StringGetAsync("data-key");
            return Ok(data.ToString());
        }
    }
}
