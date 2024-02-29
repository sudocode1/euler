namespace Euler
{
    public static class Program
    {
        public static void Main()
        {
            int sum = 0;
            for (int i = 0; i<1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine($"{i} is divisible");
                }
            }

            Console.WriteLine($"SUM: {sum}");
            Console.ReadLine();
        }

        public static void Problem879()
        {
            int[] digits = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> unusedDigits = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
            List<List<int>> possibleDigits = new List<List<int>> {
                new List<int> { 2,5,6 }, // 1
                new List<int> { 1,3,5,6,8 }, // 2
                new List<int> { 2,4,6,8,9 }, // 3
                new List<int> { 3,8,9 }, // 4
                new List<int> { 1,2,6,9,10 }, // 5
                new List<int> { 1,2,3,5,7,9,10,11 }, // 6
                new List<int> { 2,3,4,6,9,10,11,12 }, // 7
                new List<int> { 3,4,7,11,12 }, // 8
                new List<int> { 5,6,10,13,14 }, // 9
                new List<int> { 5,6,7,9,11,13,14,15 }, // 10
                new List<int> { 6,7,9,10,12,14,15,16 }, // 11
                new List<int> { 7,8,11,15,16 }, // 12
                new List<int> { 9,10,14 }, // 13
                new List<int> { 9,10,11,13,15 }, // 14
                new List<int> { 10,11,12,14,16 }, // 15
                new List<int> { 11,12,15 }, // 16
            }; 

            //2 digits


            
                
        }
    }
}