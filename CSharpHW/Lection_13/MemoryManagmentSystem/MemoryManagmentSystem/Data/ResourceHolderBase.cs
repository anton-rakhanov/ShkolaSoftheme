using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentSystem.Data
{
    public class ResourceHolderBase : IDisposable
    {
        protected SomeResources uselessResourcesBase;

        private bool _isDisposed = false;

        public ResourceHolderBase()
        {
            this.uselessResourcesBase = new SomeResources();
            Console.WriteLine("Some useless data from base class were created.");
        }

        ~ResourceHolderBase()
        {
            this.Dispose();
        }

        public virtual void UselessAction()
        {
            Console.WriteLine("Some useless action from base class");
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (uselessResourcesBase != null)
                    {
                        uselessResourcesBase.Dispose();
                    }
                }
                Console.WriteLine("Useless data from base class were finalized.");
            }
            else
            {
                Console.WriteLine("Useless data from base class are already finalized.");
            }
            _isDisposed = true;
        }
    }
}
