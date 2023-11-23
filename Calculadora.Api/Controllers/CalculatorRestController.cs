using Calculadora.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorRestController : ControllerBase
    {
        private readonly Calculator _calculator = new Calculator();

        [HttpPost("Add")]
        public IActionResult Add([FromBody] CalculationRequest request)
            => Ok(_calculator.Add(request.A, request.B));

        [HttpPost("Subtract")]
        public IActionResult Subtract([FromBody] CalculationRequest request)
            => Ok(_calculator.Subtract(request.A, request.B));

        [HttpPost("Multiply")]
        public IActionResult Multiply([FromBody] CalculationRequest request)
            => Ok(_calculator.Multiply(request.A, request.B));

        [HttpPost("Divide")]
        public IActionResult Divide([FromBody] CalculationRequest request)
            => Ok(_calculator.Divide(request.A, request.B));
    }

    public class CalculationRequest
    {
        public double A { get; set; }
        public double B { get; set; }
    }
}
