namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int min = arr[0];
            int max = arr[0];


            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);

                if (i > 0)
                    Console.Write(" ");

                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }

            Console.WriteLine();
            Console.WriteLine("МИН. ЕЛЕМЕНТ = " + min);
            Console.WriteLine("МАКС. ЕЛЕМЕНТ = " + max);

        }

    }
}

}
