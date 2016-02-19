using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Imp1
{
    public class ConcreteCloneable : Cloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Cloneable ShallowCopy()
        {
            return this.MemberwiseClone() as Cloneable;
        }
    }
}
