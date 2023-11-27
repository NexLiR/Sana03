using System;
class Program
{
    static void Main()
    {
        int N;
        bool check;
        Random rnd = new Random();
        Console.Write("Enter array size: ");
        do
        {
            check = int.TryParse(Console.ReadLine(), out N);
        } while (check == false);
        double[] array = new double[N];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(rnd.NextDouble() * 200 - 100, 2);
            Console.Write("{0}  ", array[i]);
        }
        negativeNumberSum(array);
        minArrayElement(array);
        maxElementIndex(array);
        maxAbsoluteElement(array);
        positiveElementIndexSum(array);
    }
    static void negativeNumberSum(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) sum += array[i];
        }
        if (sum == 0) Console.WriteLine("\nArray does not have negative elements");
        else Console.WriteLine("\nThe sum of negative array elements: {0}", Math.Round(sum, 2));
    }
    static void minArrayElement(double[] array)
    {
        double minElement = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (minElement > array[i]) minElement = array[i];
        }
        Console.WriteLine("Minimum element of array: {0}", minElement);
    }
    static void maxElementIndex(double[] array)
    {
        double maxElement = array[0];
        int maxElementIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (maxElement < array[i])
            {
                maxElement = array[i];
                maxElementIndex = i;
            }
        }
        Console.WriteLine("Index of maximum element of array: {0}", maxElementIndex);
    }
    static void maxAbsoluteElement(double[] array)
    {
        double maxElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (maxElement < Math.Abs(array[i])) maxElement = Math.Abs(array[i]);
        }
        Console.WriteLine("Maximum absolute element of array: {0}", maxElement);
    }
    static void positiveElementIndexSum(double[] array)
    {
        int sum = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if(sum == -1) sum = 0;
                sum += i;
            }
        }
        if (sum == -1) Console.WriteLine("Array does not have positive elements");
        else Console.WriteLine("Sum of positive elements indexes of array: {0}", sum);
    }
}