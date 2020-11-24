using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Services
{
    public interface IDroneSimulatorService
    {
        void Start(Boundary boundary, string NavigationModule);
        void Restart(Boundary boundary, string NavigationModule);
        void FlashLights();
        void ToggleLight();
        void Alert(int t);
        void NavigateHome();
        void ShutDown();
        void Move(int t, float d);
    }
}
