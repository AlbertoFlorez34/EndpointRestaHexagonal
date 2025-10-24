using EndpointRestaHexagonal.Application.DTOs;
using EndpointRestaHexagonal.Application.Ports;
using Microsoft.AspNetCore.Mvc;

namespace EndpointRestaHexagonal.Controllers
{
    [ApiController]
    [Route("api/math")]
    public class SubtractorController : ControllerBase
    {
        private readonly ISubtractorUseCase _subtractorUseCase;

        public SubtractorController(ISubtractorUseCase subtractorUseCase)
        {
            _subtractorUseCase = subtractorUseCase;
        }

        [HttpPost("subtract")]
        public async Task<IActionResult> Subtract([FromBody] SubtractRequest request)
        {
            if (request == null)
                return BadRequest("Request body is required.");

            var result = await _subtractorUseCase.SubtractAsync(request);
            return Ok(result);
        }
    }
}
