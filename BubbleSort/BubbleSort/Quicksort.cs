using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Quicksort
    {
        private IList<int> listToSort;

        public Quicksort(IList<int> listToSort)
        {
            this.listToSort = listToSort;
        }

        public IList<int> Sort()
        {
            Sort(listToSort, 0, listToSort.Count - 1);
            return listToSort;
        }

        private void Sort(IList<int> array, int start, int end)
        {
            if (end <= start) return;

            int pivot = Partition(array, start, end);
            Sort(array, start, pivot - 1);
            Sort(array, pivot + 1, end);
        }

        private int Partition(IList<int> array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            i++;
            var temp2 = array[i];
            array[i] = array[end];
            array[end] = temp2;
            return i;
        }
    }
}
