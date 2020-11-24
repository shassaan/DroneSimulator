using DroneSimulator.Core.Extensions;
using DroneSimulator.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
var serviceCollection = new ServiceCollection();
serviceCollection.RegisterDroneServices();
var DroneService = serviceCollection.BuildServiceProvider().GetService<IDroneSimulatorService>();
DroneService.Start(
    new Boundary
    {
        Px_Y = new System.Drawing.Point(0,0),
        Bx_Y = new System.Drawing.Point(0,0)
    },
    DroneSimulator.Core.DroneConstants.NavigationModules.FREEDOM
    );


DroneService.Alert(3000);
