using System;

namespace Father
{
    class JoyState : State
    {
        public JoyState()
        {
            Console.WriteLine("Отец в состоянии радости:");
            Joy();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new PityState();
                    break;

                case Mark.Five:
                    father.State = new StrongJoyState();
                    break;
            }
        }

        private void Joy()
        {
            Console.WriteLine("Отец радуется успехам сына.");
        }
    }
}
