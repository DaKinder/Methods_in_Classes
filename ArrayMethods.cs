public class ArrayMethods
{
    public void FillArray(int[] arr)
    {
        int i = 0;
        int length = arr.Length;
        for(i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(1, 20);
        }
    }
    public void FindMaxNumber(int a, int b)
    {

    }
    public void ReverseArray(int[] arr)
    {

    }
    public void FindAnyNumber(int[] arr)
    {

    }
    public void FindSecindMaxNumber(int[] arr)
    {

    }
    public void PrintArray(int[] arr, int num)

    {
        int i = 0;
        System.Console.Write("Массив - ");
        while(i < arr.Length)
        {
            Console.Write($"{arr[i]} ");
            i++;
        }
        System.Console.WriteLine();
    } 
}