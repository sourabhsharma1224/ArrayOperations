using System.Linq;
using System.Runtime.InteropServices;

namespace ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3,4,5,8,3,20 };
            string[] names = new string[] { "Sourabh", "Bob", "Boston", "Soumya", "Soumitra", "Charlie" };
            //array methods using array class
            Array.Sort(numbers); // 1. SORT method To sort array provided

            int indexOfItem =   Array.IndexOf(numbers, 3); // 2. IndexOf Method to find the index of an item

            int lastIndexOfItem = Array.LastIndexOf(numbers, 3); // 3. LastIndexOf Method to find the last index of an item.

            var findItem = Array.Find(numbers,x=>x.Equals(19)); // 4. Find method will return the value on the predicate if it doesn't finds it will return 0 (default value) in case of Integer array.

            var findNames = Array.Find(names, y => y.StartsWith("Sou"));//5. Check for Names startwith "Sou" and return only the first occurence.

            var allNames = Array.FindAll(names, x => x.Contains("Sou", StringComparison.OrdinalIgnoreCase));// 6. Use Find all method to check all names startswith specific pattern // example "Sou"

            var valueExists = Array.Exists(names,x=>x.Contains("Sourabh")); // Exist method use to check the value exist in the array based on the predicate condition.

            bool allPositive = Array.TrueForAll(numbers, n => n > 2); // TrueForAll Method used to check if the predicate condition (example: n=>n>2 is truefor all elements in array or not


            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();
            

            Console.WriteLine("Hello, World!");
        }
    }
}
