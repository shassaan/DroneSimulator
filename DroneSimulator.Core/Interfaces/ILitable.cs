using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Interfaces
{
    public interface ILitable
    {
        Task FlashLights(CancellationToken cancellationToken);
        Task ToggleLight(CancellationToken cancellationToken);
    }
}
