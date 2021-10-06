using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = 0;
            int resultOld = 0;

            result = calc.Add(5);
            Console.WriteLine($"{resultOld} + 5 = {result}");
            resultOld = result;

            result = calc.Sub(3);
            Console.WriteLine($"{resultOld} - 3 = {result}");
            resultOld = result;

            result = calc.Mul(2);
            Console.WriteLine($"{resultOld} * 2 = {result}");
            resultOld = result;

            result = calc.Div(2);
            Console.WriteLine($"{resultOld} / 2 = {result}");
            resultOld = result;

            result = calc.Undo(3);
            Console.WriteLine($"Undo 3. Reuslt: {result}");

            result = calc.Redo(2);
            Console.WriteLine($"Redo 2. Result: {result}");
        }
    }
}
