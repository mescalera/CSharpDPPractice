using DesignPatterns.Creational.ObjectPool.SecondApproach;
using DesignPatterns.Creational.ObjectPool.SecondApproach.Imp1;
using DesignPatterns.Creational.Prototype.Imp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteCloneable concrete = new ConcreteCloneable();
            concrete.Id = 1;
            concrete.Name = "Un nombre";

            ConcreteCloneable cloned = concrete.ShallowCopy() as ConcreteCloneable;
            if (cloned!=null)
            {
                cloned.Id = 3;
                cloned.Name = "Cambiado";
            }

            IObjectPool pool = ObjectPool.GetInstance();

            Parallel.For(0, 1000000, (i) =>
                {
                    IPooledObject reusable = pool.GetConnection();

                    reusable.DoSomething();

                    reusable.Release();
                });
        }
    }
}
