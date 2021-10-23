namespace FlagDrow
{
    abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottonPart();
        }

        protected abstract void DrawTopPart();
        protected abstract void DrawBottonPart();
    }
}
