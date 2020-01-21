using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever_s_up_on_my_mind
{
    public partial class RandomStuff
    {
        public static void MatrixCharacterRainingEffect()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            Console.CursorVisible = false;
//            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int k = 0; k < 1; k--)
            {
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    if (random.Next(100) < 1)
                    {
                        Console.Write(randomchar(1));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 1; j < Console.WindowHeight; j++)
                {
                    for (int i = 0; i < Console.WindowWidth; i++)
                    {

                    }
                }
            }
            Console.SetCursorPosition(0, 0);
            System.Threading.Thread.Sleep(500);
        }
        private static Random random = new Random();

        public static string randomchar(int length)
        {
            const string chars = "┏┓┗┛┣┫┳┻╋";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}