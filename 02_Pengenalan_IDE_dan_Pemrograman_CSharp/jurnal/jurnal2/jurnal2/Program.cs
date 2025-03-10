using System;

class Program
{
    static void inputNama()
    {
        Console.Write("Masukkan nama anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");
    }

    static void printIndex()
    {
        int[] arr = new int[50];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0 && arr[i] % 3 == 0)
            {
                Console.WriteLine($"{arr[i]} #$#$");
            } else if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"{arr[i]} ##");
            } else if (arr[i] % 3 == 0)
            {
                Console.WriteLine($"{arr[i]} $$");
            } else
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    static void Main()
    {
        inputNama();
        printIndex();
    }
}