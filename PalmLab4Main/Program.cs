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
            
            break;
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

