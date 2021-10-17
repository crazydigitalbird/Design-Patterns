using System;

namespace Father
{
    class PityState : State
    {
        public PityState()
        {
            Console.WriteLine("Отец в состоянии жалости:");
            Calm();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch(mark)
            {
                case Mark.Two:
                    father.State = new AngerState();
                    break;

                case Mark.Five:
                    father.State = new NeutralState();
                    break;
            }
        }

        private void Calm()
        {
            Console.WriteLine("Успокаивает сына.");
        }
    }
}
