﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Models
{
    public partial class Horn
    {
        public void Alert(int t)
        {
            Console.WriteLine("Beeping");
            Console.Beep(t,t);
        }
    }
}
