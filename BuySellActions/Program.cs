namespace BuySellActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int maxBenef(int[] input)
            {

                int[,] benefArray = new int[input.Length, input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    {

                        for (int j = i; j < input.Length; j++)
                        {
                            {
                                benefArray[i, j] = input[j] - input[i];
                            }
                        }

                    }
                }

                for (int i = 0; i < benefArray.GetLength(0); i++)
                {
                    for (int j = 0; j < benefArray.GetLength(1); j++)
                    {
                        if (j == benefArray.GetLength(1) - 1)
                        {
                            Console.WriteLine(benefArray[i, j]);
                        }
                        else
                        {
                            Console.Write(benefArray[i, j] + "        ");
                        }
                    }
                }
                return 0;
            }

            Console.WriteLine(maxBenef([7, 1, 5, 3, 6, 4]));
        }
    }
}