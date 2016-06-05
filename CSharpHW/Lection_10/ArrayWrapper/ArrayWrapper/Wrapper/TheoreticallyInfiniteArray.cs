using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ArrayWrapper.Wrapper
{
    public class TheoreticallyInfiniteArray
    {
        // Размер зубчатого массива по-умолчанию или тот который будет задан пользователем.
        private readonly int _defaultSizeOfInnerArray = 10;
        
        // Размер меньших массивов внутри зубчатого, по-умолчанюи или тот который будет задан пользователем.
        private readonly int _defaultSizeOfSmallArrays = 10;

        // Счетчик который определяет текущее количество меньших массивов внутри зубчатого.
        public int JaggedArrayCounter { get; private set; }

        // Счетчик который определяет текущее положение индекса для записи в последнем созданном меньшем массиве.
        private int _smallArrayCounter = 0;

        // Зубчатый массив
        public int[][] InnerArray { get; private set; }

        public TheoreticallyInfiniteArray()
        {
            InnerArray = new int[10][];

            InnerArray[0] = new int[_defaultSizeOfInnerArray];
            JaggedArrayCounter = 0;
        }

        public TheoreticallyInfiniteArray(int innerArraySize, int smallArraysSize)
        {
            InnerArray = new int[innerArraySize][];

            this._defaultSizeOfInnerArray = innerArraySize;
            this._defaultSizeOfSmallArrays = smallArraysSize;

            InnerArray[0] = new int[_defaultSizeOfSmallArrays];
            JaggedArrayCounter = 0;
        }

        // Метод который добавляет в зубчатый массив новый меньший массив.
        private void IncreaseInnerArraySize()
        {
            if (JaggedArrayCounter == InnerArray.Length)
            {
                Console.WriteLine("As was said before, it's theoretically infinite array, and we found the end.");
                throw new IndexOutOfRangeException();
            }
            InnerArray[++JaggedArrayCounter] = new int[_defaultSizeOfSmallArrays];
        }

        public void Add(int newElement)
        {
            if (_smallArrayCounter < _defaultSizeOfSmallArrays)
            {
                InnerArray[JaggedArrayCounter][_smallArrayCounter++] = newElement;
            }
            else
            {
                _smallArrayCounter = 0;
                IncreaseInnerArraySize();

                InnerArray[JaggedArrayCounter][_smallArrayCounter++] = newElement;
            }
        }

        public bool Contains(int seekingElement)
        {
            foreach(var arr in InnerArray)
            {
                foreach(var element in arr)
                {
                    if(seekingElement == element)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetByIndex(int index)
        {
            int smallArrIndex = 0;
            int innerArrIndex = 0;

            if (index < 0 &&
                index > (((JaggedArrayCounter + 1) * _defaultSizeOfInnerArray) - (_defaultSizeOfSmallArrays - _smallArrayCounter + 1)))
            {
                Console.WriteLine("Sorry, this index is out of range");
                return 0;
            }
            else
            {
                while ((index / _defaultSizeOfInnerArray) != 0)
                {
                    index = index - _defaultSizeOfInnerArray;
                    innerArrIndex++;
                }

                smallArrIndex = index;

                return InnerArray[innerArrIndex][smallArrIndex];
            }
        }

    }
}
