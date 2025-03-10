using System;

class Program
{
    static void deteksiHuruf()
    {
        Console.Write("Masukkan satu huruf: ");
        string huruf = Console.ReadLine().ToUpper();

        string[] hurufVokal = { "A", "I", "U", "E", "O" };

        if (Array.Exists(hurufVokal, element => element == huruf))
        {
            Console.WriteLine($"{huruf} adalah huruf vokal");
        }
        else
        {
            Console.WriteLine($"{huruf} adalah huruf konsonan");
        }
    }

    static void showArray()
    {
        int[] arrayHuruf = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < 5; i ++)
        {
            Console.WriteLine($"Angka genap {i+1}: {arrayHuruf[i]}");
        }
    }
    static void Main()
    {
        deteksiHuruf();
        showArray();
    }
}