namespace CSharp.SumAndAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items that you will enter: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter your num{i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("-------------------------------------");
            double sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            double Average = sum / arr.Length;
            Console.WriteLine($"sum of numbers={sum}, Average={Average}");
        }
    }
}
