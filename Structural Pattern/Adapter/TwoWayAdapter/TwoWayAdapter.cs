namespace TwoWayAdapter
{
    class TwoWayAdapter: ITargetOld, ITargetNew
    {
        dynamic adaptee;
        public void RequestNew()
        {
            if(adaptee == null)
            {
                adaptee = new AdapteeOld();
            }
            adaptee.RequestOld();
        }

        public void RequestOld()
        {
            if(adaptee == null)
            {
                adaptee = new AdapteeNew();
            }
            adaptee.RequestNew();
        }
    }
}
