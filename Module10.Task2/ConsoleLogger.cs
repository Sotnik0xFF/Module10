using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Task2
{
    internal class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            PrintMessage(ConsoleColor.Red, $"[LOGGER ERROR]: {message}");
        }

        public void Event(string message)
        {
            PrintMessage(ConsoleColor.Blue, $"[LOGGER EVENT]: {message}");
        }

        private void PrintMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
