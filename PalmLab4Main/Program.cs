using PalmLab4;

while (true)
{
    Console.WriteLine("Введiть номер завдання");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Введiть довжину одновимiрного масиву");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Введiть цифру вiдповiдну способу " +
                              "введення одновимiрного масиву:\n" +
                              "1 Заповнення випадковими числами\n" +
                              "2 Заповення в рядок\n3 Заповнення в стовпчик");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Введiть мiнiмальне та максимальне допустимi значення через пропуск -> ");
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
                    Console.WriteLine("BB братик\nЦе ШД-шка");
                    break;
            }

            bool blockOneGo = true;
            while (blockOneGo)
            {
                ChooseYourChampionBlock1(ref arr);
                Console.WriteLine("Ведiть q якщо не бажаєте передати щойно опрацьований масив в метод iншого учня," +
                                  " в iншому випадку натиснiть enter");
                if (String.Compare("q", Console.ReadLine(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    blockOneGo = false;
                }
            }

            break;
        case "2":
            int[][] jagArr = GetJagArr();
            bool blockTwoGo = true;
            while (blockTwoGo)
            {
                ChooseYourChampionBlock2(ref jagArr);
                Console.WriteLine("Ведiть q якщо не бажаєте передати щойно опрацьований масив в метод iншого учня," +
                                  " в iншому випадку натиснiть enter");
                if (String.Compare("q", Console.ReadLine(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    blockTwoGo = false;
                }
            }
            
            break;
        case "3":
            bool blockThreeGo = true;
            while (blockThreeGo)
            {
                Console.WriteLine("Введiть цифру вiдповiдну номеру учня\n" +
                                  "1 Марченко А.i.\n2 Каюк i.В.\n" +
                                  "3 Мартиненко О.С.\n4 Шафiєв Д.Ю.");
                switch (Console.ReadLine())
                {
                    case "1":
                        int[][] matrix = GetJagArr();
                        ChooseYourChampionBlock3(ref matrix, 1);
                        break;
                    case "2":
                        int[][] matrixIvan = GetJagArr();
                        ChooseYourChampionBlock3(ref matrixIvan, 2);
                        break;
                    case "3":
                        Console.WriteLine("Введiть довжину першого зубчастого масиву");
                        int[][] matrixLexa1 = new int[int.Parse(Console.ReadLine())][];
                        
                        Console.WriteLine("Введiть довжину другого зубчастого масиву");
                        int[][] matrixLexa2 = new int[int.Parse(Console.ReadLine())][];
                        
                        Console.WriteLine("Введiть цифру вiдповiдну способу " +
                                          "введення зубчастого масиву:\n" +
                                          "1 Заповнення випадковими числами\n" +
                                          "2 Заповення в рядок\n3 Заповнення в стовпчик");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("Введiть мiнiмальне та максимальне допустимi значення через пропуск -> ");
                                int[] bord = (from num in Console.ReadLine().Trim().Split() select int.Parse(num)).ToArray();
                                matrixLexa1 = Fillting.FillJaggedArrayWithRandom(matrixLexa1, bord.Min(), bord.Max());
                                matrixLexa2 = Fillting.FillJaggedArrayWithRandom(matrixLexa2, bord.Min(), bord.Max());

                                Console.WriteLine("Ваш перший масив:");
                                PrintJagArr(matrixLexa1);
                                Console.WriteLine("Ваш друий масив"); 
                                PrintJagArr(matrixLexa2);
                                break;
                            case "2":
                                matrixLexa1 = Fillting.FillJaggedArrayWithSpace(matrixLexa1);
                                matrixLexa2 = Fillting.FillJaggedArrayWithSpace(matrixLexa2);
                                break;
                            case "3":
                                matrixLexa1 = Fillting.FillJaggedArrayFromConsoleWithEnter(matrixLexa1);
                                matrixLexa2 = Fillting.FillJaggedArrayWithSpace(matrixLexa2);
                                break;
                            default:
                                Console.WriteLine("Некоректне занчення,перехiд до кейсу 1");
                                goto case "1";
                        }
                        Lexa.MainMethodBlock3(matrixLexa1,matrixLexa2);
                        break;
                    case "4":
                        int[,] VanArr;
                        Console.WriteLine("Введiть 1 для заповнення масиву через ентер аба 2 для заповнення через пробiл  ");
                        int choiceVan = int.Parse(Console.ReadLine());
                        Console.Write("Введiть кiлькiсть рядкiв  ");
                        int vanX = int.Parse(Console.ReadLine());
                        Console.Write("Введiть кiлькiсть стовпчикiв  ");
                        int vanY = int.Parse(Console.ReadLine());
                        Console.WriteLine(@"Введiть 1 або 0 
break;");
                        switch (choiceVan)
                        {
                            case 1 :
                                VanArr = Fillting.FillArrayFromKeyboard(vanX, vanY);
                                int[][] res1 = VanDarckhoule.VanVol3(VanArr);
                                break;
                            case 2 :
                                VanArr = Fillting.FillArrayFromKeyboard2(vanX, vanY);
                                int[][] res2 = VanDarckhoule.VanVol3(VanArr);
                                break;
                            default:
                                Console.WriteLine("Ви не ввели 1 або 2 тому вводiть через ентер");
                                goto case 1;
                                break;
                                break;
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Некоректне занчення");
                        break;
                }
                Console.WriteLine("Ведiть q якщо не бажаєте передати щойно опрацьований масив в метод iншого учня," +
                                  " в iншому випадку натиснiть enter");
                if (String.Compare("q", Console.ReadLine(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    blockThreeGo = false;
                }
            }
            
            break;
    }

    Console.WriteLine("Якщо бажаєте вийти введiть q");
    if (string.Compare(Console.ReadLine(), "q", StringComparison.OrdinalIgnoreCase) == 0)
    {
        break;
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
    Console.WriteLine("Введiть цифру вiдповiдну номеру учня\n" +
                      "1 Марченко А.i.\n2 Каюк i.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафiєв Д.Ю.");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Введiть ключ -> ");
            arr = Billy.DeleteKey(arr, int.Parse(Console.ReadLine()));
            Console.WriteLine(string.Join(", ", arr));
            break;
        case "2":
            Ivan.Find_Even_One(ref arr);
            break;
        case "3":
            Lexa.MainMethodBlock1(arr);
            break;
        case "4":
            arr = VanDarckhoule.VanVol1(arr);
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

    Console.WriteLine("Введiть цифру вiдповiдну номеру учня\n" +
                      "1 Марченко А.i.\n2 Каюк i.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафiєв Д.Ю.");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Введiть K -> ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Для того щоб виконати завдання з використанням list введiть 1," +
                              " для звичайного виконання введiть 2");
            switch (Console.ReadLine())
            {
                case "1":
                    Billy.AddKRowsInJagArrWithList(ref arrListVersion, k);
                    PrintJagArr(arrListVersion.ToArray());
                    break;
                case "2":
                    Billy.AddKRowsInJagArr(ref arr, k);
                    PrintJagArr(arr);
                    break;
                default:
                    Console.WriteLine("Некоректне значення, перехiд до кейсу 2");
                    goto case "2";
            }
            break;
        case "2":
            Ivan.Extend_Mass(ref arr);
            break;
        case "3":
            Lexa.MainMethodBlock2(arr);
            break;
        case "4":
            arr = VanDarckhoule.VanVol2(arr);
            break;
        default:
            Console.WriteLine("Некоректне занчення");
            break;
    }
}

static void ChooseYourChampionBlock3(ref int[][] arr, int variant)
{
    switch (variant)
    {
        case 1:
            Console.WriteLine("Матриця B:");
            PrintJagArr(Billy.Block3(ref arr));
            Console.WriteLine("Матриця A:");
            PrintJagArr(arr);
            break;
        case 2:
            Ivan.Change_ZeroElement_With_MinElement(ref arr);
            break;
        default:
            Console.WriteLine("Ivo Bobulo?");
            break;
    }
}

static int[][] GetJagArr()
{
    Console.WriteLine("Введiть довжину зубчастого масиву");
    int[][] arr = new int[int.Parse(Console.ReadLine())][];
    Console.WriteLine("Введiть цифру вiдповiдну способу " +
                      "введення зубчастого масиву:\n" +
                      "1 Заповнення випадковими числами\n" +
                      "2 Заповення в рядок\n3 Заповнення в стовпчик");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Введiть мiнiмальне та максимальне допустимi значення через пропуск -> ");
            int[] bord = (from num in Console.ReadLine().Trim().Split() select int.Parse(num)).ToArray();
            arr = Fillting.FillJaggedArrayWithRandom(arr, bord.Min(), bord.Max());
            Console.WriteLine("Ваш масив:");
            PrintJagArr(arr);
            break;
        case "2":
            arr = Fillting.FillJaggedArrayWithSpace(arr);
            break;
        case "3":
            arr = Fillting.FillJaggedArrayFromConsoleWithEnter(arr);
            break;
    }

    return arr;
}
