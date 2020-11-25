using DroneSimulator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Services
{
    public interface IDroneSimulatorService:IMovable,IAlertable,ILitable
    {
        void Start(Boundary boundary, string NavigationModule);
        void Restart(Boundary boundary, string NavigationModule);

        
        void ShutDown();
        
    }
}
