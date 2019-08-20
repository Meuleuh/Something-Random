using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever_s_up_on_my_mind
{
    public partial class GeneralStuff
    {
        public static int ChangeNumKeyToInt(ConsoleKeyInfo Key)
        {
            int KeyInt = -1;
            if (Key.Key == ConsoleKey.D1 || Key.Key == ConsoleKey.NumPad1)
            {
                KeyInt = 1;
            }
            else if (Key.Key == ConsoleKey.D2 || Key.Key == ConsoleKey.NumPad2)
            {
                KeyInt = 2;
            }
            else if (Key.Key == ConsoleKey.D3 || Key.Key == ConsoleKey.NumPad3)
            {
                KeyInt = 3;
            }
            else if (Key.Key == ConsoleKey.D4 || Key.Key == ConsoleKey.NumPad4)
            {
                KeyInt = 4;
            }
            else if (Key.Key == ConsoleKey.D5 || Key.Key == ConsoleKey.NumPad5)
            {
                KeyInt = 5;
            }
            else if (Key.Key == ConsoleKey.D6 || Key.Key == ConsoleKey.NumPad6)
            {
                KeyInt = 6;
            }
            else if (Key.Key == ConsoleKey.D7 || Key.Key == ConsoleKey.NumPad7)
            {
                KeyInt = 7;
            }
            else if (Key.Key == ConsoleKey.D8 || Key.Key == ConsoleKey.NumPad8)
            {
                KeyInt = 8;
            }
            else if (Key.Key == ConsoleKey.D9 || Key.Key == ConsoleKey.NumPad9)
            {
                KeyInt = 9;
            }
            else if (Key.Key == ConsoleKey.D0 || Key.Key == ConsoleKey.NumPad0)
            {
                KeyInt = 0;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Well... That was unexpected...");
            }
            return KeyInt;
        }
    }
}