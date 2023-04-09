namespace PalmLab4;

public class Ivan
{
    static void Find_Even_One(ref int[] mass)
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
    static void PrintMassAsOneString(in int[] mass)
    {
        string str = " ";
        foreach (int item in mass)
        {
            str += item + " ";
        }
        Console.WriteLine(str.Trim());
    }
    
    
    
    
    
    
    
    
    
    static bool Random_Or_Not()
    {
        bool byHand = true;
        Console.WriteLine("1 - Вручну       2 - Випадково");
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    break;
                case 2:
                    byHand = false;
                    break;
                default:
                    Console.WriteLine("1 - Вручну       2 - Випадково");
                    break;
            }
        } while (n < 1 | n > 2);
        return byHand;
    }
    static void Add_Row(ref int[][] mass, in int index)
    {
        Console.WriteLine("\nРядок, який додається, вписується");
        if (Random_Or_Not())
        {
            mass[index] = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
        }
        else
        {
            Random rnd = new Random();
            mass[index] = new int[rnd.Next(1, 11)];
            string str = "";
            for (int i = 0; i < mass[index].Length; i++)
            {
                mass[index][i] = rnd.Next(-100, 101);
                str += mass[index][i] + " ";
            }
            Console.WriteLine($"\nДоданий випадковий рядок\n{str.Trim()}");
        }
    }
    
    
    
    
    
    
    
    
    
    static void Change_ZeroElement_With_MinElement(ref int[][] mass, in int n)
    {
        for (int i = 0; i < n; i++)
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
    }
    static void Row_With_Max_Element(in int[][] mass, in int n, out int index)
    {
        int maxInt = mass[0][0];
        index = 0;
        for (int i = 1; i < n; i++)
        {
            if (mass[i][0] > maxInt)
            {
                maxInt = mass[i][0];
                index = i;
            }
        }
    }
}