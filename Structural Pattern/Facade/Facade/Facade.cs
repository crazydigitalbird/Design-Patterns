namespace Facade
{
    class Facade
    {
        private SubSystemA subSystemA;
        private SubSystemB subSystemB;
        private SubSystemC subSystemC;

        public Facade()
        {
            this.subSystemA = new SubSystemA();
            this.subSystemB = new SubSystemB();
            this.subSystemC = new SubSystemC();
        }

        public void OperationAB()
        {
            this.subSystemA.OperationA();
            this.subSystemB.OperationB();
        }

        public void OperationBC()
        {
            this.subSystemB.OperationB();
            this.subSystemC.OperationC();
        }
    }
}