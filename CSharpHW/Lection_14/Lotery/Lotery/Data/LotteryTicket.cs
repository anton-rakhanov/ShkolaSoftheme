using System;

namespace Lotery.Data
{
    class LotteryTicket
    {
        private int[] _combination;


        public LotteryTicket()
        {
            _combination = new int[6];
        }


        public LotteryTicket(params int[] winningCombination)
        {
            _combination = winningCombination;
        }


        public int this[int index]
        {
            get
            {
                if (IsValueValid(index))
                {
                    return _combination[index];
                }
                else
                {
                    return -1;
                }
            }

            set
            {
                if (IsValueValid(index))
                {
                    _combination[index] = value;
                }
                else
                {
                    Console.WriteLine("You have been tried set value by invalid index!");
                }
            }
        }


        private bool IsValueValid(int index)
        {
            if(index < 0 || index > 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int[] GetCombination()
        {
            return _combination;
        }

    }
}
