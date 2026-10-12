using Microsoft.AspNetCore.Mvc;
using TestProject.Services;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConverterController : ControllerBase
    {
        private readonly ConverterService _converterService;

        public ConverterController()
        {
            _converterService = new ConverterService();
        }

        // POST: api/converter/length
        [HttpPost("length")]
        public IActionResult LengthConverted([FromBody] double meterlenght)
        {
            try
            {
                if (meterlenght < 0)
                {
                    return BadRequest(new
                    {
                        Message = "Length cannot be negative."
                    });
                }

                double centimeters = _converterService.lengthConverter(meterlenght);
                return Ok(new
                {
                    Meters = meterlenght,
                    Centimeters = centimeters
                });
            }
            catch
            {
                return BadRequest("An error occurred while conversion");
            }
        }

        // POST: api/converter/temperature
        [HttpPost("temperature")]
        public IActionResult TemperatureConverted(
            [FromBody] double temperature)
        {
            try
            {
                double value = _converterService.temperatureConverter(temperature);

                return Ok(new
                {
                    Message = "Temperature converted successfully.",
                    ConvertedValue = value
                });
            }
            catch
            {
                return BadRequest("An error occurred while conversion");
            }
        }

        // POST: api/converter/weight
        [HttpPost("weight")]
        public IActionResult WeightConverted(
            [FromBody] double weight)
        {
            try
            {
                double value =_converterService.weightConverter(weight);

                return Ok(new
                {
                    Message = "Weight converted successfully.",
                    ConvertedValue = value
                });
            }
            
            catch
            {
                return BadRequest("An error occurred while conversion");
            }
        }
    }
}
