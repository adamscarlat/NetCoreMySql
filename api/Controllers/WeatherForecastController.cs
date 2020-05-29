using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NetCoreRestMySql.models;

namespace NetCoreRestMySql.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(WeatherApiDbContext dbContext, ILogger<WeatherForecastController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherApiDbContext _dbContext;

        [HttpGet]
        public async Task<List<WeatherDataPoint>> Get()
        {
            return await _dbContext.WeatherDataPoint.ToListAsync();
        }
    }
}
