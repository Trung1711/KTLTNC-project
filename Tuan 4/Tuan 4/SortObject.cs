using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    static class SortObject
    {

        private static ISortObject[] arrayToSort;

        private static void Swap(int sortedIndex, int comparedIndex)
        {
            int temp = sortedIndex;
            sortedIndex = comparedIndex;
            comparedIndex = temp;
        }
        public static void Sort(ISortObject[] array)
        {
            arrayToSort = array;
            bool isRightOrder = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                isRightOrder = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    int p = Convert.ToInt32(array[j]);
                    int p2 = Convert.ToInt32(array[j + 1]);
                    if (p > p2)
                    {
                        Swap(p, p2);
                        isRightOrder = true;
                    }
                }
                if (isRightOrder == false)
                {
                    break;
                }
            }
        }
    }
}

