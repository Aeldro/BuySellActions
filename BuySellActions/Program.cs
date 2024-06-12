namespace BuySellActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int maxBenef(int[] input)
            {
                int addition = 0;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] < input[i + 1])
                    {
                        addition = addition + (input[i + 1] - input[i]);
                    }
                }
                return addition;
            }

            Console.WriteLine(maxBenef([7, 6, 4, 3, 1]));
        }
    }
}