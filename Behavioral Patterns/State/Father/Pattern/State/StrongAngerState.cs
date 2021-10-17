using System;

namespace Father
{
    class StrongAngerState : State
    {
        public StrongAngerState()
        {
            Console.WriteLine("Отец в состоянии сильного гнева:");
            BeatBelt();
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

        private void BeatBelt()
        {
            Console.WriteLine("Бъет сына ремнем.");
        }
    }
}