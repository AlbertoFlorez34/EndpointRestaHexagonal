using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndpointRestaHexagonal.Application.DTOs;
using EndpointRestaHexagonal.Application.Ports;

namespace EndpointRestaHexagonal.Application.UseCases.Subtractor
{
    public class SubtractorUseCase : ISubtractorUseCase
    {
        public Task<SubtractResult> SubtractAsync(SubtractRequest request)
        {
            var result = request.A - request.B;
            return Task.FromResult(new SubtractResult(result));
        }
    }
}
