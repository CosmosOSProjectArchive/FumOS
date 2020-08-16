using System;

namespace FumOS.Apps
{
    public class Piano : IExecutable
    {
        private bool exit;

        public Piano()
        {
            exit = false;
        }

        public void Execute()
        {

            while (!exit)
            {
                switch (Console.ReadKey().Key)
                {
                    // First octave

                    // C4
                    case ConsoleKey.Z:
                        Console.Beep(261, 100);
                        break;

                    // C#4
                    case ConsoleKey.S:
                        Console.Beep(277, 100);
                        break;

                    // D4
                    case ConsoleKey.X:
                        Console.Beep(293, 100);
                        break;

                    // D#4
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

                    // F#4
                    case ConsoleKey.G:
                        Console.Beep(369, 100);
                        break;

                    // G4
                    case ConsoleKey.B:
                        Console.Beep(391, 100);
                        break;

                    // G#4
                    case ConsoleKey.H:
                        Console.Beep(415, 100);
                        break;

                    // A4
                    case ConsoleKey.N:
                        Console.Beep(440, 100);
                        break;

                    // A#4
                    case ConsoleKey.J:
                        Console.Beep(466, 100);
                        break;

                    // B4
                    case ConsoleKey.M:
                        Console.Beep(493, 100);
                        break;

                    // Second octave

                    // C5
                    case ConsoleKey.OemComma:
                        Console.Beep(523, 100);
                        break;

                    // C5 (second binding)
                    case ConsoleKey.Q:
                        Console.Beep(523, 100);
                        break;

                    // C#5
                    case ConsoleKey.D2:
                        Console.Beep(554, 100);
                        break;

                    // D5
                    case ConsoleKey.OemPeriod:
                        Console.Beep(587, 100);
                        break;

                    // D5 (second binding)
                    case ConsoleKey.W:
                        Console.Beep(587, 100);
                        break;

                    // D#5
                    case ConsoleKey.D3:
                        Console.Beep(622, 100);
                        break;

                    // E5
                    case ConsoleKey.Oem2:
                        Console.Beep(659, 100);
                        break;

                    // E5 (second binding)
                    case ConsoleKey.E:
                        Console.Beep(659, 100);
                        break;

                    // F5
                    case ConsoleKey.R:
                        Console.Beep(698, 100);
                        break;

                    // F#5
                    case ConsoleKey.D5:
                        Console.Beep(739, 100);
                        break;

                    // G5
                    case ConsoleKey.T:
                        Console.Beep(783, 100);
                        break;

                    // G#5
                    case ConsoleKey.D6:
                        Console.Beep(830, 100);
                        break;

                    // A5
                    case ConsoleKey.Y:
                        Console.Beep(880, 100);
                        break;

                    // A#5
                    case ConsoleKey.D7:
                        Console.Beep(932, 100);
                        break;

                    // B5
                    case ConsoleKey.U:
                        Console.Beep(987, 100);
                        break;

                    // Escape
                    case ConsoleKey.Escape:
                        Console.WriteLine("");
                        exit = true;
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
