using System;
class Program
{
    private static int min;

    static void Main()
    {
        int N;
        Random rnd = new Random();
        Console.Write("Enter array size: ");
        bool check = int.TryParse(Console.ReadLine(), out N);
        double[] array = new double[N];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(rnd.NextDouble() * 200 - 100, 2);
            Console.Write("{0}  ", array[i]);
        }
    }
}