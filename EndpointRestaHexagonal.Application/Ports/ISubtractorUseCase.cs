using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndpointRestaHexagonal.Application.DTOs;

namespace EndpointRestaHexagonal.Application.Ports
{
    public interface ISubtractorUseCase
    {
        Task<SubtractResult> SubtractAsync(SubtractRequest request);
    }
}
