using System;
using Sys = Cosmos.System;

namespace CosmosTest
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Piano();
        }

        private void Piano()
        {
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    // First octave

                    // C4
                    case ConsoleKey.Z:
                        Console.Beep(261, 100);
                        break;

                    // C4#
                    case ConsoleKey.S:
                        Console.Beep(277, 100);
                        break;

                    // D4
                    case ConsoleKey.X:
                        Console.Beep(293, 100);
                        break;

                    // D4#
                    case ConsoleKey.D:
                        Console.Beep(311, 100);
                        break;

                    // E4
                    case ConsoleKey.C:
                        Console.Beep(329, 100);
                        break;

                    // F4
                    case ConsoleKey.V:
                        Console.Beep(349, 100);
                        break;

                    // F4#
                    case ConsoleKey.G:
                        Console.Beep(369, 100);
                        break;

                    // G4
                    case ConsoleKey.B:
                        Console.Beep(391, 100);
                        break;

                    // G4#
                    case ConsoleKey.H:
                        Console.Beep(415, 100);
                        break;

                    // A4
                    case ConsoleKey.N:
                        Console.Beep(440, 100);
                        break;

                    // A4#
                    case ConsoleKey.J:
                        Console.Beep(466, 100);
                        break;

                    // B4
                    case ConsoleKey.M:
                        Console.Beep(493, 100);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
