namespace PalmLab4;

public class Billy
{
    public static int[] DeleteKey(int[] arr, int key)
    {
        bool change = false;
        int delIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                delIndex = i;
                change = true;
                break;
            }
        }
    
        if (change)
        {
            int insertIndex = 0;
            int[] resultArr = new int[arr.Length - 1];
            for (int i = 0; i < delIndex; i++, insertIndex++)
            {
                resultArr[insertIndex] = arr[i];
            }
    
            for (int i = delIndex + 1; i < arr.Length; i++, insertIndex++)
            {
                resultArr[insertIndex] = arr[i];
            }
    
            return resultArr;
        }
        Console.WriteLine("Значення не знайдено");
        return arr;
    }
    
    public static void Add3RowsInTwoDimArr(ref int[][] arr)
    {
        Array.Resize(ref arr, arr.Length + 3);
        for (int i = arr.Length - 4; i >= 0; i--)
        {
            arr[i + 3] = arr[i];
        }
    
        for (int i = 0; i < 3; i++)
        {
            arr[i] = new int[arr[3].Length];
        }
    }
    
    public static void Add3RowsInTwoDimArrWithList(ref List<int[]> list)
    {
        for (int i = 0; i < 3; i++)
        {
            list.Insert(0, new int[list[0].Length]);
        }
    }
    
    public static int[][] Block3(ref int[][] arrA)
    {
        int[][] arrB = new int[arrA.Length][];
        for (int i = 0; i < arrA.Length; i++)
        {
            int startIndex = arrA[i].First(), endIndex = arrA[i].Last();
            if (startIndex > endIndex)
            {
                (startIndex, endIndex) = (endIndex, startIndex);
            }
    
            int[] tempArr = new int[endIndex - startIndex];
            for (int j = 0; j + startIndex < endIndex; j++)
            {
                tempArr[j] = arrA[i][j + startIndex];
            }
    
            arrB[i] = tempArr;
        }
    
        foreach (var intArr in arrA)
        {
            Array.Sort(intArr);
        }
    
        return arrB;
    }
}