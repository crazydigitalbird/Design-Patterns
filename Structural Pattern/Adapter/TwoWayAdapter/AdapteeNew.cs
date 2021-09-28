using System;

namespace TwoWayAdapter
{
    class AdapteeNew : ITargetNew
    {
        public void RequestNew()
        {
            Console.WriteLine("AdapteeNew.RequestNew");
        }
    }
}
