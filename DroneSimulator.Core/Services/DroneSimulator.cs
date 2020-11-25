using DroneSimulator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public async Task FlashLights(CancellationToken cancellationToken)
        {
            if (Drone is null)
                throw new Exception("Drone is not started yet");
            await Drone.Light.Flash(cancellationToken);
        }

        public void Move(int t, float d)
        {
            if(Drone.NavigationModule == DroneConstants.NavigationModules.RAILS)
            {
                if (!new float[] { 0, 90, 180, 270, 360 }.Contains(d))
                    throw new Exception($"Rails module can only travel to {string.Join(",", new float[] { 0, 90, 180, 270, 360 })}");
                Drone.Move(t, d,
                (currentPosition) =>
                {
                    Console.WriteLine($"Current Position (0,{currentPosition})");
                });

            }
            else
            {
                Drone.Move(t, d,
                (currentPosition) =>
                {
                    Console.WriteLine($"Current Position (0,{currentPosition})");
                });
            }
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

        public async Task ToggleLight(CancellationToken cancellationToken)
        {
            
            if(Drone is null)
                throw new Exception("Drone is not started yet");
            await Drone.Light.Toggle(cancellationToken);
        }
    }
}
