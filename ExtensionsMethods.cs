public static class ExtensionsMethods
{
    public static void FillArrayStatic(int[] arr)
    {
        int i = 0;
        int length = arr.Length;
        for(i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(1, 20);
        }
    }
    public static void PrintArrayStatic(int[] arr, int num)

    {
        int i = 0;
        System.Console.Write($"Массив {num} - ");
        while(i < arr.Length)
        {
            Console.Write($"{arr[i]} ");
            i++;
        }
        System.Console.WriteLine();
    }
    public static void Print(this DateTime dateTime)
    {
        Console.WriteLine(dateTime);
    }

}