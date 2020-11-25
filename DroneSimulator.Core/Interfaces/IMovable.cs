using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Interfaces
{
    public interface IMovable
    {
        void Move(int t, float d);
    }
}
