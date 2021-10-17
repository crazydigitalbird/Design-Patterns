using System;

namespace Father
{
    class AngerState : State
    {
        public AngerState()
        {
            Console.WriteLine("Отец в состоянии гнева:");
            Scold();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new StrongAngerState();
                    break;

                case Mark.Five:
                    father.State = new NeutralState();
                    break;
            }
        }

        private void Scold()
        {
            Console.WriteLine("Отец ругает сына за плохие оценки.");
        }
    }
}
