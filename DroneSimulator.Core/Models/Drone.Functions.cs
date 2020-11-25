using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Models
{
    public partial class Drone
    {
        public void Move(int t,float d,Action<float> callBack)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(t))
            {
                d++;
                callBack(d);
            }

            s.Stop();
        }
    }
}
