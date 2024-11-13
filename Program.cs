namespace MergeAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting project:");
            int[] arr = { 2, 1, 5, 4 };
            Print(arr);
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };
            int[] c = new int[a.Length + b.Length];
            Sort.Merge(a, b, c);
            Console.WriteLine("After merging:");
            Print(c);
        }
        // C# code to merge two sorted arrays into a third one
        

        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
