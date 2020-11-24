using DroneSimulator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Services
{
    public class DroneSimulatorService : IDroneSimulatorService
    {
        private Drone Drone { get; set; }

        public void Alert(int t)
        {
            if (Drone is null)
                throw new Exception("Drone is not started yet");
            Drone.Horn.Alert(t);
        }

        public void FlashLights()
        {
            if (Drone is null)
                throw new Exception("Drone is not started yet");
            Drone.Light.Flash();
        }

        public void Move(int t, float d)
        {
            throw new NotImplementedException();
        }

        public void NavigateHome()
        {
            throw new NotImplementedException();
        }

        public void Restart(Boundary boundary, string NavigationModule)
        {
            Start(boundary,NavigationModule);
        }

        public void ShutDown()
        {
            Drone = null;
        }

        public void Start(Boundary boundary, string NavigationModule)
        {
            Drone = new Drone();
            Drone.Boundary = boundary;
            Drone.NavigationModule = NavigationModule;
            Drone.Horn = new Horn();
            Drone.Light = new Light();
        }

        public void ToggleLight()
        {
            throw new NotImplementedException();
        }
    }
}
