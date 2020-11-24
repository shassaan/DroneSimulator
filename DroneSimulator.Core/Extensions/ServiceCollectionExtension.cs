using DroneSimulator.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterDroneServices(this ServiceCollection services)
        {
            services.AddSingleton<IDroneSimulatorService, DroneSimulatorService>();
        }
    }
}
