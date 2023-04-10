using PalmLab4;

while (true)
{
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
                    Console.WriteLine($"Ваш масив: {String.Join(", ", arr)}\n");
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

            bool blockOneGo = true;
            while (blockOneGo)
            {
                ChooseYourChampionBlock1(ref arr);
                Console.WriteLine("Ведіть q якщо не бажаєте передати щойно опрацьований масив в метод іншого учня," +
                                  " в іншому випадку натисніть enter");
                if (String.Compare("q", Console.ReadLine(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    blockOneGo = false;
                }
            }

            break;
        case "2":
            Console.WriteLine("Введіть довжину зубчастого масиву");
            int[][] JagArr = new int[int.Parse(Console.ReadLine())][];
            Console.WriteLine("Введіть цифру відповідну способу " +
                              "введення зубчастого масиву:\n" +
                              "1 Заповнення випадковими числами\n" +
                              "2 Заповення в рядок\n3 Заповнення в стовпчик");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Введіть мінімальне та максимальне допустимі значення через пропуск -> ");
                    int[] bord = (from num in Console.ReadLine().Trim().Split() select int.Parse(num)).ToArray();
                    JagArr = Fillting.FillJaggedArrayWithRandom(JagArr, bord.Min(), bord.Max());
                    Console.WriteLine("Ваш масив:");
                    PrintJagArr(JagArr);
                    break;
                case "2":
                    JagArr = Fillting.FillJaggedArrayFromConsoleWithSpace(JagArr);
                    break;
                case "3":
                    JagArr = Fillting.FillJaggedArrayFromConsoleWithEnter(JagArr);
                    break;
            }
            bool blockTwoGo = true;
            while (blockTwoGo)
            {
                ChooseYourChampionBlock2(ref JagArr);
                Console.WriteLine("Ведіть q якщо не бажаєте передати щойно опрацьований масив в метод іншого учня," +
                                  " в іншому випадку натисніть enter");
                if (String.Compare("q", Console.ReadLine(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    blockTwoGo = false;
                }
            }
            
            break;
        case "3":
            ChooseYourChampionBlock3();
    }
}

static void PrintJagArr(int[][] arr)
{
    foreach (var oneDimArr in arr)
    {
        Console.WriteLine(String.Join(", ", oneDimArr));
    }
}

static void ChooseYourChampionBlock1(ref int[] arr)
{
    Console.WriteLine("Введіть цифру відповідну номеру учня\n" +
                      "1 Марченко А.І.\n2 Каюк І.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафієв Д.Ю.");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Введіть ключ -> ");
            arr = Billy.DeleteKey(arr, int.Parse(Console.ReadLine()));
            Console.WriteLine(string.Join(", ", arr));
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Некоректне занчення");
            break;
    }
}
static void ChooseYourChampionBlock2(ref int[][] arr)
{
    List<int[]> arrListVersion = new List<int[]>(arr.Length);
    foreach (var oneDimArr in arr)
    {
        arrListVersion.Add(oneDimArr);
    }

    Console.WriteLine("Введіть цифру відповідну номеру учня\n" +
                      "1 Марченко А.І.\n2 Каюк І.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафієв Д.Ю.");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Для того щоб виконати завдання з використанням list введіть 1," +
                              " для звичайного виконання введіть 2");
            switch (Console.ReadLine())
            {
                case "1":
                    Billy.Add3RowsInJagArrWithList(ref arrListVersion);
                    PrintJagArr(arrListVersion.ToArray());
                    break;
                case "2":
                    Billy.Add3RowsInJagArr(ref arr);
                    PrintJagArr(arr);
                    break;
                default:
                    Console.WriteLine("Некоректне значення, перехід до кейсу 2");
                    goto case "2";
            }
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Некоректне занчення");
            break;
    }
}

static void ChooseYourChampionBlock3()
{
    Console.WriteLine("Введіть цифру відповідну номеру учня\n" +
                      "1 Марченко А.І.\n2 Каюк І.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафієв Д.Ю.");
    switch (Console.ReadLine())
    {
        case "1":
            
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Некоректне занчення");
            break;
    }
}