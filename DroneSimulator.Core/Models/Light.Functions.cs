using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DroneSimulator.Core.Models
{
    public partial class Light
    {
        public async Task Flash(CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine("Light Flash");
                }
            },cancellationToken);
        }

        public async Task Toggle(CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine("Toggle");
                }
            }, cancellationToken);
        }
    }
}
