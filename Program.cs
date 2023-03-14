public static class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Это программа длы работы с массивами");

        //создаём массивы и выделяем им место в памяти с помошью команды "new".
        int[] array1 = new int[5];
        int[] array2 = new int[10] {5, 54, 24, 8, 10,33, 9, 12, 91, 6};
        int[] array3 = new int[15];

        //для обращения к методам текущего статического класса "Program"
        //не требуется указывать имя класса111
        FillArray(array1);

                                            //КЛАССЫ!!! КЛАССЫ!!! КЛАССЫ!!!
        //создаём экземпляр НЕстатического класса "ArrayMethods" (array - экземпляр класса)
        //При необъодимости можно создать несколько экземпляров
        ArrayMethods array = new ArrayMethods();

        //НЕСТАТИЧЕСКИЙ КЛАСС!!! НЕСТАТИЧЕСКИЕ МЕТОДЫ!!!
        //Вызов НЕстатического метода FillArray НЕстатического класса "ArrayMethods"
        //возможен только от имени экземпляра(array)!!! Только так!!!
        array.FillArray(array1);
        
        //повторение, но с другим НЕстатическим методом.
        array.PrintArray(array1, 1);

        //ОСОБОЕ ВНИМАНИЕ!!! ДАЛЕЕ ИДУТ СТАТИЧЕСКИЕ МЕТОДЫ!!!
        //Вызов статического метода PrintArrayStatic НЕстатического класса "ArrayMethods"
        //возможен только от имени класса(ArrayMethods). Только так!!!
        ArrayMethods.PrintArrayStatic(array2, 2);

        //для обращения к методам статического класса, экземпляр класса создать НЕВОЗМОЖНО!!!
        //вызов статического метода FillArrayStatic статического класса "ExtensionsMethods"
        //возможен только от имени класса(ExtensionsMethods). Только так!!!
        ExtensionsMethods.FillArrayStatic(array3);
        
        //повторение, но с другим статическим методом.
        ExtensionsMethods.PrintArrayStatic(array3, 3);


        //это пока не изучаем!!!
        //Вызов метода Print из классса Extensions
        DateTime currentDateTime = DateTime.Now;
        ExtensionsMethods.Print(currentDateTime);
    }
    
    public static void FillArray(int[] arr)
    {
        int i = 0;
        int length = arr.Length;
        for(i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(1, 20);
        }
    }
    public static void FindMaxNumber(int a, int b)
    {

    }
    public static void ReverseArray(int[] arr)
    {

    }
    public static void FindAnyNumber(int[] arr)
    {

    }
    public static void FindSecindMaxNumber(int[] arr)
    {

    }
    public static void PrintArray(int[] arr)
    {
        int i = 0;
        Console.Write("Массив 1 - ");
        while(i < arr.Length)
        {
            Console.Write($"{arr[i]} ");
            i++;
        }
    }
    
}