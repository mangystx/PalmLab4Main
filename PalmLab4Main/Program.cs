using PalmLab4;

Console.WriteLine("Введіть номер завдання");
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("Введіть довжину одновимірного масиву");
        int[] arr = new int[int.Parse(Console.ReadLine())]; 
        Console.WriteLine("Введіть цифру відповідну способу " +
                          "введення одновимірного масиву:\n" +
                          "1 Заповнення випадковими числами\n" +
                          "2 Заповення в рядок\n3 Заповнення в стовпчик");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Введіть мінімальне та максимальне допустимі значення через пропуск -> ");
                int[] bord = (from num in Console.ReadLine().Trim().Split() select int.Parse(num)).ToArray();
                arr = Fillting.FillArrayWithRandom(arr, bord.Min(), bord.Max());
                Console.WriteLine($"Ваш масив: {String.Join(", ", arr)}");
                break;
            case "2":
                arr = Fillting.FillArrayFromConsoleWithSpace(arr);
                break;
            case "3":
                arr = Fillting.FillArrayFromConsoleWithEnter(arr);
                         break;
            default:
                Console.WriteLine("Видалення папки System32 через: 3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);
                Console.WriteLine("BB");
                break;
        }

        switch (ChooseYourChampion())
        {
            case 1:
                Console.Write("Введіть ключ -> ");
                arr = Billy.DeleteKey(arr, int.Parse(Console.ReadLine()));
                Console.WriteLine(string.Join(", ", arr));
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Некоректне занчення");
                break;
        }
        break;
}

static int ChooseYourChampion()
{
    Console.WriteLine("Введіть цифру відповідну номеру учня\n" +
                      "1 Марченко А.І.\n2 Каюк І.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафієв Д.Ю.");
    return int.Parse(Console.ReadLine());
}

