using DroneSimulator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Services
{
    public class Drone
    {
        public Boundary Boundary { get; set; }
        public Light Light { get; set; }
        public Horn Horn { get; set; }
    }
}
