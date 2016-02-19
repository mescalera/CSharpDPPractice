using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool.FirstApproach.Imp1
{
    public class ObjectPool : IObjectPool
    {
        private object objLock = new object();
        private IList<IPooledObject> pooledObjects;

        private static ObjectPool instance = new ObjectPool();

        private ObjectPool()
        {
            pooledObjects = new List<IPooledObject>();
        }

        public static ObjectPool GetInstance()
        {
            return instance;
        }

        public IPooledObject GetConnection()
        {
            lock(objLock)
            {
                IPooledObject pooledObject = pooledObjects.FirstOrDefault();
                if (pooledObject!=null)
                {
                    pooledObjects.Remove(pooledObject);
                }
                return pooledObject;
            }
        }

        public void ReleaseConnection(IPooledObject connection)
        {
            lock(objLock)
            {
                pooledObjects.Add(connection);
            }
        }
    }
}
