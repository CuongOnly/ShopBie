using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBie.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            // khi hủy thứ tự dispose thì sẽ ko dispose
            Dispose(false);
        }

        public void Dispose()
        {
            // khi dispose gọi GC các SuppressFinalize để thu hoạch bộ nhớ
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
        }
        //Overide this to dispose custom objects
        protected virtual void DisposeCore()
        {

        }
    }
}
