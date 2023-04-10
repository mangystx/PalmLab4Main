namespace PalmLab4
{
    internal class Fillting
    {
        public static int[,] FillArrayRandom(int rows, int cols)
        {
            int[,] array = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }
            return array;
        }
        public static int[,] FillArrayFromKeyboard(int rows, int cols)
        {
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Введіть елемент [{0}, {1}]: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }
        public static int[,] FillArrayFromKeyboard2(int n, int m)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть елементи {i + 1}-го рядка через пробіл: ");
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }
            return matrix;
        }
        public static int[] FillArrayWithRandom(int[] arr, int minValue, int maxValue)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(minValue, maxValue);
            }
            return arr;
        }
        public static int[] FillArrayFromConsoleWithSpace(int[] arr)
        {
            Console.WriteLine("Введiть {0} {1} через пробiл:", arr.Length, arr.Length is > 1 and <= 4 ? "числа" : "чисел");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }
            return arr;
        }
        public static int[] FillArrayFromConsoleWithEnter(int[] arr)
        {
            Console.WriteLine("Введiть {0} {1} по одному:", arr.Length, arr.Length is > 1 and <= 4 ? "числа" : "чисел");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        public static int[][] FillJaggedArrayWithRandom(int[][] arr, int minValue, int maxValue)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rand.Next(1, 6)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(minValue, maxValue);
                }
            }
            return arr;
        }
        public static int[][] FillJaggedArrayFromConsoleWithSpace(int[][] arr)
        {
            Console.WriteLine("Введiть {0} {1}, кожний через пробiл:", arr.Length, arr.Length is > 1 and <= 4 ? "масива" : "масивів");
            for (int i = 0; i < arr.Length; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');
                arr[i] = new int[inputArr.Length];
                for (int j = 0; j < inputArr.Length; j++)
                {
                    arr[i][j] = int.Parse(inputArr[j]);
                }
            }
            return arr;
        }
        public static int[][] FillJaggedArrayFromConsoleWithEnter(int[][] arr)
        {
            Console.WriteLine("Введiть {0} {1}, кожний по одному числу:", arr.Length, arr.Length is > 1 and <= 4 ? "масива" : "масивів");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введiть кількiсть чисел в масивi {i + 1}:");
                int length = int.Parse(Console.ReadLine());
                arr[i] = new int[length];
                
                Console.WriteLine("Введiть {0} {1} масива {2}:", length, length is > 1 and <= 4 ? "числа" : "чисел", i + 1);
                for (int j = 0; j < length; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
    }
}