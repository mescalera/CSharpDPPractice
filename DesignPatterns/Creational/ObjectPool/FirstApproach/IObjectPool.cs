﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool.FirstApproach
{
    public interface IObjectPool
    {
        IPooledObject GetConnection();
        void ReleaseConnection(IPooledObject connection);
    }
}
