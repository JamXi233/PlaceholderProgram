using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceholderProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.Clear();
                Console.WriteLine("按下回车结束程序\nPress [Enter] Key to end this Program");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
    }
}
