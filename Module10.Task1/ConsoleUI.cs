using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Task1
{
    public static class ConsoleUI
    {
        public static string GetString(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }

        public static double GetDouble(string message) => Double.Parse(GetString(message));

        public static void ShowMessage(string message) => Console.WriteLine(message);

        public static bool YesNoQuestion(string message)
        {
            while (true)
            {
                switch (GetString($"{message} [y/n]"))
                {
                    case "y": return true;
                    case "n": return false;
                    default: break;
                }
            }
        }
    }
}
