using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace DesignPatterns.Creational.ObjectPool.SecondApproach.Imp1
{
    public class ObjectPool : IObjectPool
    {
        private ConcurrentBag<IPooledObject> pool;

        private static IObjectPool instance = new ObjectPool();

        private ObjectPool() 
        {
            pool = new ConcurrentBag<IPooledObject>();
        }

        public static IObjectPool GetInstance()
        {
            return instance;
        }

        public IPooledObject GetConnection()
        {
            IPooledObject item;
            if (!pool.TryTake(out item))
            {
                item = new Reusable(new Action<IPooledObject>(p => releaseObject(p)));
            }
            return item;
        }

        private void releaseObject(IPooledObject reusable)
        {
            pool.Add(reusable);
        }
    }
}
