using DroneSimulator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Models
{
    public partial class Horn : ISwitchable
    {
        public bool Switch { get ; set ; }
    }
}
