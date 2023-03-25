using System;
using System.Text;

namespace Module10.Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool run = true;
            while(run)
            {
                try
                {
                    RunCalculator(new Calculator());
                }
                catch (Exception e)
                {
                    ConsoleUI.ShowMessage(e.Message);
                }
                finally
                {
                    run = ConsoleUI.YesNoQuestion("Перезапустить?");
                }
            }
            ConsoleUI.ShowMessage("Программа завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }

        public static void RunCalculator(ICalculator calculator)
        {
            double a = ConsoleUI.GetDouble("Введите операнд А");
            double b = ConsoleUI.GetDouble("Введите операнд B");
            ConsoleUI.ShowMessage($"Сумма: {calculator.Sum(a, b)}");
        }
    }
}
