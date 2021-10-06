namespace Calculator
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            this.arithmeticUnit = new ArithmeticUnit();
            this.controlUnit = new ControlUnit();
        }

        private int Run(Command command)
        {
            this.controlUnit.StoreCommand(command);
            this.controlUnit.ExecuteCommand();
            return this.arithmeticUnit.Result;
        }

        public int Add(int operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public int Sub(int operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public int Mul(int operand)
        {
            return Run(new Mul(arithmeticUnit, operand));
        }

        public int Div(int operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }

        public int Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithmeticUnit.Result;
        }

        public int Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.Result;
        }
    }
}
