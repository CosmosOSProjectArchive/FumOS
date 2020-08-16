using Cosmos.Core;
using FumOS.Apps;
using System;

namespace FumOS
{
    public class Shell
    {
        private readonly Kernel _kernel;

        public Shell(Kernel kernel)
        {
            _kernel = kernel;
            Start();
        }

        private void Start()
        {
            while (true)
            {
                Console.Write("fumos> ");
                var command = Console.ReadLine();

                switch (command)
                {
                    case "clear":
                        Console.Clear();
                        break;

                    case "piano":
                        new Piano();
                        break;

                    case "shutdown":
                        ACPI.Shutdown();
                        break;

                    default:
                        Console.WriteLine("unknown command");
                        break;
                }
            }
        }
    }
}
