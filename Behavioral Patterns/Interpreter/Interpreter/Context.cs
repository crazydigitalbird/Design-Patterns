namespace Interpreter
{
    //Контекс распознающей грамматики языка:
    //V = {a}; L = V*;
    //Правильные цепочки: a aa aaa ...
    //Неправильные цепочки: b ab aba ...
    class Context
    {
        public char Vocabulary { get; set; } 

        public string Source { get; set; }

        public bool Result { get; set; }

        public int Position { get; set; }
    }
}
