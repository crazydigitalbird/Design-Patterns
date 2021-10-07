namespace Interpreter
{
    class NonterminalExpression: AbstractExpression
    {
        private TerminalExpression terminal;

        private NonterminalExpression nonterminal;

        public override void Interpret(Context context)
        {
            if(context.Position < context.Source.Length)
            {
                terminal = new TerminalExpression();
                terminal.Interpret(context);
                context.Position++;

                if(context.Result)
                {
                    nonterminal = new NonterminalExpression();
                    nonterminal.Interpret(context);
                }
            }
        }
    }
}
