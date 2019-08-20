using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever_s_up_on_my_mind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisis une option");
            Console.WriteLine();
//            Console.WriteLine("1-");
//            Console.WriteLine("2- ");
//            Console.WriteLine("3- ");
//            Console.WriteLine("4- ");
//            Console.WriteLine("5- ");
//            Console.WriteLine("6- ");
//            Console.WriteLine("7- ");
//            Console.WriteLine("8- ");
//            Console.WriteLine("9- ");
            Console.WriteLine("0- Next Page");
            ConsoleKeyInfo Choix = Console.ReadKey();
            int ChoixInt = GeneralStuff.ChangeNumKeyToInt(Choix);
            switch (ChoixInt)
            {
                case 1:
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < 100; i--)
                    {
                        System.Threading.Thread.Sleep(10);
                        for (int j = 0; j < Console.WindowHeight; j++)
                        {
                            string AChar = GeneralStuff.randomchar(Console.WindowWidth);
                            Console.SetCursorPosition(0, j);
                            Console.WriteLine(AChar);
                        }
                    }
                    break;
            }
        }
    }
}
