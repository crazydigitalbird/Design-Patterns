using System;

namespace Father
{
    class StrongJoyState : State
    {
        public StrongJoyState()
        {
            Console.WriteLine("Отец в состоянии сильной радости:");
            Exuit();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch(mark)
            {
                case Mark.Two:
                    father.State = new PityState();
                    break;

                case Mark.Five:
                    father.State = new StrongJoyState();
                    break;
            }
        }

        private void Exuit()
        {
            Console.WriteLine("Ликует и гордится сыном.");
        }
    }
}
