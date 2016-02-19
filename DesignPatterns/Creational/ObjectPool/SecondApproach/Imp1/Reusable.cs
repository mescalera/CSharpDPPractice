using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool.SecondApproach.Imp1
{
    public class Reusable : IPooledObject
    {
        private Action<IPooledObject> releaseObject;
        double count;
        Guid guid;

        public Reusable(Action<IPooledObject> release)
        {
            guid = Guid.NewGuid();
            releaseObject = release;
        }

        public void DoSomething()
        {
            Random random = new Random();
            Random realRandom = new Random(random.Next(0, 1000));

            int ticks = realRandom.Next(0, int.MaxValue);

            for(int i=0; i< ticks; i++)
            {
                count += i;
            }
        }

        public void Release()
        {
            Console.WriteLine("El GUID: {0} ha contado {1}", guid, count);
            count = 0;

            if (releaseObject!=null)
            {
                releaseObject(this);
            }
        }
    }
}
