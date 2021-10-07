using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context { Vocabulary = 'a', Source = "aaa" };
            NonterminalExpression nonterminal = new NonterminalExpression();
            nonterminal.Interpret(context);

            Console.WriteLine(context.Result);
        }
    }
}
