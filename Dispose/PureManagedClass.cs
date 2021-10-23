using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class PureManagedClass : IDisposable
    {

        private StreamWriter _mWriter;
        private bool disposedValue;

        public void StartWriting()
        {
            _mWriter = new StreamWriter("output.txt");
        
        }

        //public void Dispose()
        //{
        //    Console.WriteLine("PureManagedClass::Dispose");
        //    _mWriter?.Dispose();
        //    GC.SuppressFinalize(this);
        //}

        ~PureManagedClass()
        {
            Console.WriteLine("PureManagedClass::Finalizing");
            //_mWriter?.Dispose();
        }

        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("PureManagedClass::Dispose: " + disposing);
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        // // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        // ~PureManagedClass()
        // {
        //     // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
