using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Module10.Task1;

namespace Module10.Task2
{
    internal class LoggedCalculator : ICalculator
    {
        private readonly ILogger _logger;
        private readonly ICalculator _calculator;

        public LoggedCalculator(ICalculator calculator, ILogger logger)
        {
            _calculator = calculator;
            _logger = logger;
        }

        public double Sum(double x, double y)
        {
            _logger.Event($"Вычисление суммы {x} и {y}...");
            return _calculator.Sum(x, y);
        }
    }
}
