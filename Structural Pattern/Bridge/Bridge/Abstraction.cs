namespace Builder
{
    abstract class Abstraction
    {
        private Implementor implementor;

        public Abstraction(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
