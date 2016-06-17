using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortWithTailRecursion.Alghoritm
{
    public class TailRecursionQuickSort
    {

        public int OperationCounter { get; set; }


        int[] _sortingArray;


        public TailRecursionQuickSort(int[] unsortedArray)
        {
            this._sortingArray = unsortedArray;
        }


        public void Sort(int lower, int upper)
        {

            int pi;

            while(lower < upper)
            {

                pi = Partition(lower, upper);

                if(pi - lower < upper - pi)
                {
                    Sort(lower, pi - 1);
                    lower = pi + 1;

                    OperationCounter++;
                }
                else
                {
                    Sort(pi + 1, upper);
                    upper = pi - 1;

                    OperationCounter++;
                }

            }

        }

        private int Partition(int lower, int upper)
        {
            int pivot = _sortingArray[upper];

            int i = lower - 1;

            for(int j = lower; j <= upper - 1; j++)
            {
                if(_sortingArray[j] <= pivot)
                {
                    i++;
                    Swap(i, j);

                    OperationCounter++;
                }
            }


            Swap(i + 1, upper);

            OperationCounter++;

            return i + 1;

        }

        private void Swap(int i, int j)
        {
            int temp = _sortingArray[i];
            _sortingArray[i] = _sortingArray[j];
            _sortingArray[j] = temp;
        }

    }
}
