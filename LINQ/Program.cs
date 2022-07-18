namespace LINQ
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
            int evenNumbers = nums.Count(n => n % 2 == 0);
            int minimum = nums.Min(n => n);
            int maximum = nums.Max(n => n); 
            int[] bigNumbers = nums.Where(n => n >= 100000 && n <= 999999).ToArray();
            int[] tentoOneHundred = nums.Where(n => n > 10 && n < 100).ToArray();
            int maximumAndLess = nums.Where(n => n < 10000).Max(n => n);

            Console.WriteLine($"The Minimum value is {minimum}");
            Console.WriteLine($"The Maximum value is {maximum}");
            Console.WriteLine($"The Maximum value less then 10000 is {maximumAndLess}");
            Console.Write("The numbers between 10 and 100 are: ");
            foreach(int num in tentoOneHundred)
            {
                Console.Write($"{num} ");
            }
            Console.Write("\nThe inclusive numbers between 100000 and 999999 are: ");
            foreach(int num in bigNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine($"\nThere are {evenNumbers} even numbers in the array");
        }
    }
}