using LeetCodeProblems.Array101;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortArrayByParity sortArrayByParity = new SortArrayByParity();
            int[] nums = { 3, 1, 2, 4 };
            nums = sortArrayByParity.SortArrayByParitySol(nums);

            printArray(nums);
        }

        public static void printArray(int[] arra)
        {
            Console.Write("[");
            foreach (int i in arra)
            {
                Console.Write(i);
                Console.Write(",");
            }
            Console.Write("]");
        }
    }
}