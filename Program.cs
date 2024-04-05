using LeetCodeProblems.InPlaceArrayOperations;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreatestElementOnRight greatestElement = new GreatestElementOnRight();

            int[] arr = { 400 };
            arr = greatestElement.ReplaceElements(arr);

            printArray(arr);
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