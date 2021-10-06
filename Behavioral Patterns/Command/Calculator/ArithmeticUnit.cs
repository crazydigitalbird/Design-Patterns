namespace Calculator
{
    //"Receiver" (Получатель) - Арифметическое устройство (АУ)
    class ArithmeticUnit
    {
        public int Result { get; private set; }

        public void Run(char operation, int operand)
        {
            switch (operation)
            {
                case '+':
                    Result += operand;
                    break;

                case '-':
                    Result -= operand;
                    break;

                case '*':
                    Result *= operand;
                    break;

                case '/':
                    Result /= operand;
                    break;
            }
        }
    }
}
