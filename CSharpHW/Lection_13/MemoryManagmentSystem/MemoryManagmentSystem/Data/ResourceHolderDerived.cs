using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentSystem.Data
{
    public class ResourceHolderDerived : ResourceHolderBase, IDisposable
    {
        protected SomeResources uselessResourcesDerived;

        private bool _isDisposed = false;

        public ResourceHolderDerived()
        {
            this.uselessResourcesDerived = new SomeResources();
            Console.WriteLine("Some useless data from derived class were created.");
        }

        ~ResourceHolderDerived()
        {
            this.Dispose();
        }

        public override void UselessAction()
        {
            Console.WriteLine("Some useless action from derived class");
        }

        public new void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
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
                Console.WriteLine("Useless data from derived class were finalized.");
            }
            else
            {
                Console.WriteLine("Useless data from derived clas are already finalized.");
            }
            _isDisposed = true;
        }
    }
}
