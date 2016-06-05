using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImplementation.QuickSort
{
    public class QuickSorter
    {
        private int[] _array;

        private int temp;

        public QuickSorter(int[] _unsortedArray)
        {
            this._array = _unsortedArray;
        }

        public void Sort(int begin, int end)
        {
            int index = _array[begin + (end - begin) / 2];

            int i = begin;
            int j = end;

            while (i <= j)
            {

                while (_array[i] < index)
                {
                    i++;
                }
                while (_array[j] > index)
                {
                    j--;
                }
                
                if(i <= j)
                {
                    Swap(i++, j--);
                }

            }

            if(i < end)
            {
                Sort(i, end);
            }
            if(begin < j)
            {
                Sort(begin, j);
            }
        }

        private void Swap(int i, int j)
        {
            temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;
        }

    }
}
