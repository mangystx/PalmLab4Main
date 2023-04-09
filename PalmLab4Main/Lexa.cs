using System;

namespace Lb4
{
    public class Program
    {
        static int[] FindCountNegNum(int[] arrayStartNumbers)
        {
            int counerNegativeNumbers = 0;
            int[] indexesOfAllNegativeArrayElements = new int[0];
            for (int i = 0; i < arrayStartNumbers.Length; i++)
            {
                if (arrayStartNumbers[i] < 0)
                {
                    counerNegativeNumbers++;
                }
            }
            if (counerNegativeNumbers != 0)
            {
                indexesOfAllNegativeArrayElements = FindIndexesNegNum(arrayStartNumbers, counerNegativeNumbers);
            }
            return indexesOfAllNegativeArrayElements;
        }
        static int[] FindIndexesNegNum(int[] arrayStartNumbers, int counerNegativeNumbers)
        {
            int[] indexesOfAllNegativeArrayElements = new int[counerNegativeNumbers];
            for (int i = 0, j = 0; i < arrayStartNumbers.Length; i++)
            {
                if (arrayStartNumbers[i] < 0)
                {
                    indexesOfAllNegativeArrayElements[j] = i;
                    j++;
                }
            }
            return indexesOfAllNegativeArrayElements;
        }
        static int[] ResizePrimaryArray(ref int[] arrayStartNumbers, int[] indexesOfAllNegativeArrayElements)
        {
            Array.Resize(ref arrayStartNumbers, arrayStartNumbers.Length + indexesOfAllNegativeArrayElements.Length);
            return arrayStartNumbers;
        }
        static int[] Replace(ref int[] arrayStartNumbers, int[] indexesOfAllNegativeArrayElements)
        {
            for (int i = 1; i < indexesOfAllNegativeArrayElements.Length + 1; i++)
            {
                for (int j = arrayStartNumbers.Length - 1; j > indexesOfAllNegativeArrayElements[i - 1] + i; j--)
                {
                    (arrayStartNumbers[j], arrayStartNumbers[j - 1]) = (arrayStartNumbers[j - 1], arrayStartNumbers[j]);
                }
            }
            return arrayStartNumbers;
        }
        static int[] ReplaceZeros(ref int[] arrayStartNumbers, int[] indexesOfAllNegativeArrayElements)
        {
            for (int i = 0; i < indexesOfAllNegativeArrayElements.Length; i++)
            {
                arrayStartNumbers[indexesOfAllNegativeArrayElements[i] + i + 1] = Math.Abs(arrayStartNumbers[indexesOfAllNegativeArrayElements[i] + i]);
            }
            return arrayStartNumbers;
        }
        static int[][] ResizeStartArray_Block2(ref int[][] arrayStart)
        {
            Array.Resize(ref arrayStart, arrayStart.Length + 1);
            for (int i = arrayStart.Length - 1; i > arrayStart.Length - 2; i--)
            {
                arrayStart[i] = new int[5];
            }
            return arrayStart;
        }
        static int[][] ReplaceStartArray_Block2(ref int[][] arrayStart, int indexMaxVal)
        {
            (arrayStart[indexMaxVal - 1], arrayStart[arrayStart.GetLength(0) - 1]) = (arrayStart[arrayStart.GetLength(0) - 1], arrayStart[indexMaxVal - 1]);
            return arrayStart;
        }
        static void MainBlock1()
        {
            int[] arrayStartNumbers = { 3, 6, 9, -96, -4, 12, -4 };
            int[] indexesOfAllNegativeArrayElements = FindCountNegNum(arrayStartNumbers);
            if (indexesOfAllNegativeArrayElements.Length != 0)
            {
                ResizePrimaryArray(ref arrayStartNumbers, indexesOfAllNegativeArrayElements);
                Replace(ref arrayStartNumbers, indexesOfAllNegativeArrayElements);
                ReplaceZeros(ref arrayStartNumbers, indexesOfAllNegativeArrayElements);
            }
        }
        public void MainMethodBlock2()
        {
            int[][] arrayStart = { };
            int indexMaxVal = 0;
            ResizeStartArray_Block2(ref arrayStart);
            ReplaceStartArray_Block2(ref arrayStart, indexMaxVal); //indexMaxValInArray наибольший елемент миссива 
        }
        static int[] FindAndFillArrayWithIdenticalElement(int[][] arrayOfNumbers_First, int[][] arrayOfNumbers_Second)
        {
            int[] arrayIdenticalElements = new int[0];
            for (int i = 0; i < arrayOfNumbers_First.GetLength(0) & i < arrayOfNumbers_Second.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers_First[i].Length & j < arrayOfNumbers_Second[i].Length; j++)
                {
                    if (arrayOfNumbers_First[i][j] == arrayOfNumbers_Second[i][j])
                    {
                        Array.Resize(ref arrayIdenticalElements, arrayIdenticalElements.Length + 1);
                        arrayIdenticalElements[arrayIdenticalElements.Length - 1] = arrayOfNumbers_First[i][j];
                    }
                }
            }
            if (arrayIdenticalElements.Length != 0)
            {
                Console.WriteLine("Елементи мартиць які співпадають за індексами та значеннями ");
                for (int i = 0; i < arrayIdenticalElements.Length; i++)
                {
                    Console.Write($"{arrayIdenticalElements[i]} ");
                }
                return FindNumOfSelectNum(arrayIdenticalElements, arrayOfNumbers_First, arrayOfNumbers_Second);
            }
            else
            {
                Console.WriteLine("Не має жодного числа в обох масивах які співпадають за індексом та значенням");
                return arrayIdenticalElements;
            }
        }
        static int[] FindNumOfSelectNum(int[] arrayIdenticalElements, int[][] arrayOfNumbers_First, int[][] arrayOfNumbers_Second)
        {
            if (arrayIdenticalElements.Length != 0)
            {
                int sumRowsAndColm = SumAllRowsAndColmInTwoArrays(arrayOfNumbers_First, arrayOfNumbers_Second);
                Console.WriteLine("\nВведіть число");
                int numTheFindInArr = int.Parse(Console.ReadLine());
                int[] indexFindNum = new int[2];
                bool chekCompliteIteration = false;
                for (int i = 0, j = 0; i < arrayIdenticalElements.Length; i++)
                {
                    if (numTheFindInArr == arrayIdenticalElements[i])
                    {
                        indexFindNum[j] = i;
                        chekCompliteIteration = true;
                        if (j < 1)
                        {
                            j++;
                        }
                    }
                }
                if (chekCompliteIteration == false)
                {
                    Console.WriteLine("Значення яке ви шукаєте не знайдено!");
                    return arrayIdenticalElements;
                }
                if (indexFindNum[1] != 0)
                {
                    int index1 = indexFindNum[0] % sumRowsAndColm;
                    int index2 = indexFindNum[1] % sumRowsAndColm;
                    if (index1 < arrayOfNumbers_First.GetLength(0) & index2 < arrayOfNumbers_First[index1].Length)
                    {
                        Console.WriteLine($"Елемент {index1 + 1}-го рядка {index2 + 1}-го стовпчика був замінений з {arrayOfNumbers_First[index1][index2]} на {numTheFindInArr}");
                        arrayOfNumbers_First[index1][index2] = numTheFindInArr;
                    }
                    else
                    {
                        Console.WriteLine($"Індексів які були вказані програмою були більші ніж розмір масиву");
                    }
                }
                else
                {
                    int index1 = indexFindNum[0] % sumRowsAndColm;
                    if (index1 < arrayOfNumbers_Second.GetLength(0) & index1 < arrayOfNumbers_Second[index1].Length)
                    {
                        Console.WriteLine($"Елемент {index1 + 1}-го рядка {index1 + 1}-го стовпчика був замінений з {arrayOfNumbers_First[index1][index1]} на {numTheFindInArr}");
                        arrayOfNumbers_Second[index1][index1] = numTheFindInArr;
                    }
                    else
                    {
                        Console.WriteLine($"Індексів які були вказані програмою були більші ніж розмір масиву");
                    }
                }
                return arrayIdenticalElements;
            }
            else
            {
                Console.WriteLine();
                return arrayIdenticalElements;
            }
        }
        static int SumAllRowsAndColmInTwoArrays(int[][] arrayOfNumbers_First, int[][] arrayOfNumbers_Second)
        {
            int sumRowsAndColm = arrayOfNumbers_First.GetLength(0) * 2;
            for (int i = 0; i < arrayOfNumbers_First.GetLength(0); i++)
            {
                sumRowsAndColm += arrayOfNumbers_First[i].Length * 2;
            }
            return sumRowsAndColm;
        }
        public void MainMethodBlock3()
        {
            int[][] arrayOfNumbers_First = null;
            int[][] arrayOfNumbers_Second = null;
            FindAndFillArrayWithIdenticalElement(arrayOfNumbers_First, arrayOfNumbers_Second);
        }
    }
}