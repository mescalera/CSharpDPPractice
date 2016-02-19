using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool.SecondApproach
{
    public interface IPooledObject
    {
        void DoSomething();
        void Release();
    }
}
