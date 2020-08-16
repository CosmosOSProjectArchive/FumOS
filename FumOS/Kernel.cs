using System;
using Sys = Cosmos.System;

namespace FumOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("FumOS 0.1");
            Console.WriteLine("Touhou plush and Disk Operating System");
        }

        protected override void Run()
        {
            new Shell();
        }
    }
}
