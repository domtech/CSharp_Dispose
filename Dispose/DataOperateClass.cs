using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class DataOperateClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("DataOperateClass::Disposed!");
        }
    }
}
