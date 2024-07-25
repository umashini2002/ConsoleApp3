namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 }; 
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            double average = total / numbers.Length;
            Console.WriteLine($"total ={ total},average = {average}");


        }
    }
}
