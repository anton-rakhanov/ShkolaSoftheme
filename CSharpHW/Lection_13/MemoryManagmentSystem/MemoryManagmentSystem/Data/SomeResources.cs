using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentSystem.Data
{
    public class SomeResources : IDisposable
    {
        private int[, ,] _threeDimensionArrayOfInts;

        private bool _isDisposed = false;

        public SomeResources()
        {
            this._threeDimensionArrayOfInts = new int[100, 100, 100];
        }

        ~SomeResources()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            if (_threeDimensionArrayOfInts != null && !_isDisposed)
            {
                GC.SuppressFinalize(this);
                if(_threeDimensionArrayOfInts == null)
                {
                    Console.WriteLine("Private useless resources were finalized");
                }
            }
            else
            {
                Console.WriteLine("Private useless data are already finalized.");
            }
            _isDisposed = true;
        }
    }
}
