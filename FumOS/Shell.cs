using FumOS.Apps;
using System;

namespace FumOS
{
    public class Shell
    {
        public Shell()
        {
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
                    case "piano":
                        new Piano();
                        break;

                    case "shutdown":
                        Power.Shutdown();
                        break;

                    case "reboot":
                        Power.Reboot();
                        break;

                    default:
                        Console.WriteLine("unknown command");
                        break;
                }
            }
        }
    }
}
