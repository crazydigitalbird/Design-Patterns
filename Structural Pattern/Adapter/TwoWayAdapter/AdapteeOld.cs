using System;

namespace TwoWayAdapter
{
    class AdapteeOld : ITargetOld
    {
        public void RequestOld()
        {
            Console.WriteLine("AdapteOld.RequestOld");
        }
    }
}
