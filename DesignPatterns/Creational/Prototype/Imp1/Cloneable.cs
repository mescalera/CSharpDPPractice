using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Imp1
{
    public interface Cloneable
    {
        Cloneable ShallowCopy();
    }
}
