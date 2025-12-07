using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class MergeSort
    {
        private int[] arrayToSort;
        public MergeSort(int[] arrayToSort) {
            this.arrayToSort = arrayToSort;
        }
        public int[] Sort()
        {
            Sort(arrayToSort);
            return arrayToSort;
        }

        private void Sort(int[] array)
        {
            if (array.Length < 2) {  return; }
            
            int leftLength = array.Length/2;
            int rightLength = array.Length - leftLength;

            int[] leftArray = new int[leftLength];
            int[] rightArray = new int[rightLength];
        
            Array.Copy(array, 0, leftArray, 0, leftLength);
            Array.Copy(array, leftLength, rightArray, 0, rightLength);

            Sort(leftArray);
            Sort(rightArray);

            Sorting(array, leftArray, rightArray);
        }

        void Sorting(int[] sortedArray, int[] leftArray, int[] rightArray)
        {
            {
                int s = 0, r = 0, l = 0;

                while (l < leftArray.Length && r < rightArray.Length)
                {
                    if (leftArray[l] <= rightArray[])
                    {
                        sortedArray[s] = leftArray[l];
                        s++;
                        l++;
                    }
                    else
                    {
                        sortedArray[s] = rightArray[r];
                        s++;
                        r++;
                    }
                }
                while (l < leftArray.Length)
                {
                    sortedArray[s] = leftArray[l];
                    s++;
                    l++;
                }
                while (r < rightArray.Length)
                {
                    sortedArray[s] = rightArray[r];
                    s++;
                    r++;
                }
            }
        }
    }
}
