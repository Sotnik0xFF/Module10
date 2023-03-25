using System;

using Module10.Task1;

namespace Module10.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ILogger logger = new ConsoleLogger();
            ICalculator calculator = new LoggedCalculator(new Calculator(), logger);

            bool run = true;
            while (run)
            {
                logger.Event("Запуск программы...");
                try
                {
                    Task1.Program.RunCalculator(calculator);
                }
                catch (Exception e)
                {
                    logger.Error(e.Message);
                }
                finally
                {
                    run = ConsoleUI.YesNoQuestion("Перезапустить?");
                }
            }
            ConsoleUI.ShowMessage("Программа завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
