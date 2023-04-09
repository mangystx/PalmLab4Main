namespace PalmLab4;

public class Ivan
{
    //Завдання №1
    static int[] Find_Even_One(ref int[] mass)
    {
        if (Is_Even_Exists(in mass, out int indexOfEvenNumber))
        {
            Console.WriteLine($"\nНомер парного елементу |{indexOfEvenNumber + 1}|");
            Delete_Element(ref mass, mass.Length, indexOfEvenNumber);
            Console.WriteLine("\nРезультуючий масив");
            PrintMassAsOneString(in mass);
        }
        else
        {
            Console.WriteLine("\nНемає парних елементiв в масивi");
        }
        return mass;
    }
    static bool Is_Even_Exists(in int[] mass, out int indexOfEvenNumber)
    {
        indexOfEvenNumber = -1;
        bool isEven = false;
        foreach (int item in mass)
        {
            indexOfEvenNumber++;
            if (Math.Abs(item) % 2 == 0)
            {
                isEven = true;
                break;
            }
        }
        return isEven;
    }
    static void Delete_Element(ref int[] mass, int n, int indexOfEvenNumber)
    {
        indexOfEvenNumber++;
        while (indexOfEvenNumber < n)
        {
            mass[indexOfEvenNumber - 1] = mass[indexOfEvenNumber];
            indexOfEvenNumber++;
        }
        Array.Resize(ref mass, n - 1);
    }
    //Завдання №2
    static int[][] Extend_Mass(ref int[][] mass)
    {
        Array.Resize(ref mass, mass.Length + 1);
        Add_Row(ref mass, in BonusRow_Index());
        Console.WriteLine("/nРезультуючий масив");
        Print_Jagged_Mass(in mass);
        return mass;
    }
    static int BonusRow_Index()
    {
        Console.WriteLine("\nВи додаєте рядок з номером");
        int index = int.Parse(Console.ReadLine()) - 1;
        return index;
    }
    static void Add_Row(ref int[][] mass, in int index)
    {
        Console.WriteLine("\nРядок, який додається, вписується");
        mass[index] = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
    }
    //Завдання №3
    static int[][] Change_ZeroElement_With_MinElement(ref int[][] mass)
    {
        for (int i = 0; i < mass.Length; i++)
        {
            int minInt = mass[i][0];
            int k = 0;
            for (int j = 1; j < mass[i].Length; j++)
            {
                if (mass[i][j] < minInt)
                {
                    minInt = mass[i][j];
                    k = j;
                }
            }
            int temp = mass[i][0];
            mass[i][0] = mass[i][k];
            mass[i][k] = temp;
        }
        Row_With_Max_Element(in int[][] mass, out int index)
        Array.Reverse(mass[index]);
        Console.WriteLine("/nРеверсивний рядок");
        PrintMassAsOneString(in mass[index]);
        Console.WriteLine("/nРезультуючий масив");
        Print_Jagged_Mass(in mass);
        return mass;
    }
    static void Row_With_Max_Element(in int[][] mass, out int index)
    {
        int maxInt = mass[0][0];
        index = 0;
        for (int i = 1; i < mass.Length; i++)
        {
            if (mass[i][0] > maxInt)
            {
                maxInt = mass[i][0];
                index = i;
            }
        }
    }
    static void PrintMassAsOneString(in int[] mass)
    {
        string str = " ";
        foreach (int item in mass)
        {
            str += item + " ";
        }
        Console.WriteLine(str.Trim());
    }
    static void Print_Jagged_Mass(in int[][] mass)
    {
        for (int i = 0; i < mass.Length; i++)
        {
            string str = " ";
            for (int j = 0; j < mass[i].Length; j++)
            {
                str += mass[i][j] + " ";
            }
            Console.WriteLine(str.Trim());
        }
    }
}
