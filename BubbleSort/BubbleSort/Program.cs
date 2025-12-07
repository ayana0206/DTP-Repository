using BubbleSort;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int> { 4, 2, 7, 10, 5, 1, 5, 2, 0 };
            int[] array = { 4, 2, 7, 10, 5, 1, 5, 2, 0 };


            BubbleSort sorter = new BubbleSort(list);

            Console.WriteLine("BubbleSort");
            foreach (int i in sorter.Sort())
            {
                Console.WriteLine(i);
            }

            Quicksort sorter2 = new Quicksort(list);

            Console.WriteLine("Quicksort");
            foreach (int i in sorter2.Sort())
            {
                Console.WriteLine(i);
            }

            MergeSort sorter3 = new MergeSort(array);

            Console.WriteLine("Mergesort");
            foreach (int i in sorter3.Sort())
            {
                Console.WriteLine(i);
            }


        }
    }
}
