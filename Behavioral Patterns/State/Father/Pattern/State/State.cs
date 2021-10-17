namespace Father
{
    abstract class State
    {
        public virtual void HandleMark(Father father, Mark mark)
        {
            ChangeState(father, mark);
        }

        protected abstract void ChangeState(Father father, Mark mark);
    }
}
