public static class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Это программа длы работы с массивами");

        //создаём массив и выделили ему место в памяти с помошью команды "new".
        int[] array1 = new int[10] {4, 6, 2, 8, 5, 1, 4, 9, 3, 7};

        int[] array2 = new int[10];
        
        //создаём экземпляр нестатичееского класса "Methods" (method - экзкмпляр класса)      
        ArrayMethods arrayZ = new ArrayMethods();
        ArrayMethods arrayX = new ArrayMethods();
        arrayZ.FillArray(array1);
        arrayX.FillArray(array2);

        //вызываем метод вывода массива в консоль.
        arrayZ.PrintArray(array1, 1);        
        arrayX.PrintArray(array2, 2);

        //Вызов Extensions
        DateTime currentDateTime = DateTime.Now;
        ExtensionsMethods.Print(currentDateTime);
    }
    /*
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
    */
}