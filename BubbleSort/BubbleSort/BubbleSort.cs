using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class BubbleSort
    {
        private IList<int> listToSort;
        public BubbleSort(IList<int> listToSort) 
        {
            this.listToSort = listToSort;
        }
        public IList<int> Sort()
        {
            Boolean swaped = true;

            int length = listToSort.Count;
            while (swaped == true)
            {
                swaped = false;
                for (var i = 0; i < length-1; i++)
                {              
                    if (listToSort[i] > listToSort[i + 1])
                    {
                        var temp = listToSort[i];
                        listToSort[i] = listToSort[i + 1];
                        listToSort[i + 1] = temp;
                        swaped = true;
                    }
                }
                length--;
            }
            return listToSort;
        }
    }
}
