using System;
using System.Collections.Generic;

namespace TwoWayAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITargetOld> targetOlds = new List<ITargetOld>();
            targetOlds.Add(new AdapteeOld());
            targetOlds.Add(new TwoWayAdapter());

            foreach(ITargetOld targetOld in targetOlds)
            {
                targetOld.RequestOld();
            }

            Console.WriteLine(new String('-', 20));

            List<ITargetNew> targetNews = new List<ITargetNew>();
            targetNews.Add(new AdapteeNew());
            targetNews.Add(new TwoWayAdapter());

            foreach(ITargetNew targetNew in targetNews)
            {
                targetNew.RequestNew();
            }
        }
    }
}
