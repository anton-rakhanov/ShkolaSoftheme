using System;


namespace InsertionSorts.Alghorithm
{
    public class InsertionSort
    {

        public int OperationCounter { get; private set; }



        public int[] Sort(int[] array)
        {

            int j;
            int temp;


            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                temp = array[i];

                while (j > 0 && array[j - 1] > temp)
                {
                    array[j] = array[j - 1];

                    OperationCounter++;

                    --j;
                }

                array[j] = temp;

            }

            return array;
        }
    }
}
