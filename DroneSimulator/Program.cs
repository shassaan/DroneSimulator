using DroneSimulator.Core.Extensions;
using DroneSimulator.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;

namespace DroneSimulator
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            try
            {
                var serviceCollection = new ServiceCollection();
                serviceCollection.RegisterDroneServices();
                var DroneService = serviceCollection.BuildServiceProvider().GetService<IDroneSimulatorService>();
                DroneService.Start(
                    new Boundary
                    {
                        Px_Y = new System.Drawing.Point(0, 0),
                        Bx_Y = new System.Drawing.Point(0, 0)
                    },
                    DroneSimulator.Core.DroneConstants.NavigationModules.RAILS
                    );


                DroneService.Alert(3000);


                var FlashCTS = new CancellationTokenSource();
                DroneService.FlashLights(FlashCTS.Token);
                Thread.Sleep(5000);
                FlashCTS.Cancel();


                var ToggleCTS = new CancellationTokenSource();
                DroneService.ToggleLight(ToggleCTS.Token);
                Thread.Sleep(5000);
                ToggleCTS.Cancel();


                DroneService.Move(3, 91);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

