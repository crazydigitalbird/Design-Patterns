namespace Template_Method
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimiteveOperation2();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimiteveOperation2();
    }
}
