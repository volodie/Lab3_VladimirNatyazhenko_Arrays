using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //PrintOdd();
        //PrintFiveNumbers();
        //SumNumbers();
        //Scanner();
        //CreateAndFillArray();
        //CreateAndPrintArray();
        //Fibon();
        //CreatePrintArrayReplase();
        //CreateAndSortArray();
    }
    static void PrintOdd()
    {
        for (int i = 0; i <= 99; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("Нечетное число " + i);
            }
        }
    }
    static void PrintFiveNumbers()
    {
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine("Число " + i);
        }
    }
    static void SumNumbers()
    {
        Console.WriteLine("Введите положительное число: ");
        try
        {
            uint number = uint.Parse(Console.ReadLine());
            uint sumOfNumbers = 0;
            for (int i = 1; i <= number; i++)
            {
                sumOfNumbers = (uint)(sumOfNumbers + i);
            }
            Console.WriteLine("Число " + sumOfNumbers);
        }
        catch (Exception)
        {
            Console.WriteLine("Вы ввели не положительное число!"); ;
        }
    }
    static void Scanner()
    {
        Random random = new Random();
        byte[] arrayOfNumbers = new byte[20];
        random.NextBytes(arrayOfNumbers);
        for(int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(" " + arrayOfNumbers[i] );
        }
        Console.WriteLine();
        Console.WriteLine("Введите число: ");
        byte number = byte.Parse(Console.ReadLine());
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == number)
            {
                Console.WriteLine("Число " + number + " есть в массиве");
                break;
            }
        }
    }
    static void CreateAndFillArray()
    {
        Console.WriteLine("Введите размерность массива: ");
        byte count = byte.Parse(Console.ReadLine());

        Random random = new Random();
        int[] arrayOfNumbers = new int[count];
  
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = random.Next(); 
        }
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(" " + arrayOfNumbers[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Введите число: ");
        int maxValue = arrayOfNumbers[0];
        int minValue = arrayOfNumbers[0];
        int sumValuesArray = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            sumValuesArray = sumValuesArray + arrayOfNumbers[0];
            if (arrayOfNumbers[i] > maxValue)
            {
                maxValue = arrayOfNumbers[i];
            }
            if (arrayOfNumbers[i] < minValue)
            {
                minValue = arrayOfNumbers[i];
            }
        }
        int averageValue = 0;
        averageValue = sumValuesArray / count;
        Console.WriteLine("Максимальное число массива = " + maxValue);
        Console.WriteLine("Минимальное число массива = " + minValue);
        Console.WriteLine("Среднее значение массива = " + averageValue);
    }

    static void CreateAndPrintArray()
    {
        Console.WriteLine("Введите размерность массива: ");
        byte count = byte.Parse(Console.ReadLine());
        Random random = new Random();
        int[] arrayOfNumbersFirst = new int[count];

        for (int i = 0; i < arrayOfNumbersFirst.Length; i++)
        {
            arrayOfNumbersFirst[i] = random.Next(); 
        }
        for (int i = 0; i < arrayOfNumbersFirst.Length; i++)
        {
            Console.Write(" " + arrayOfNumbersFirst[i]);
        }
        Console.WriteLine();

        int[] arrayOfNumbersSecond = new int[count];

        for (int i = 0; i < arrayOfNumbersSecond.Length; i++)
        {
            arrayOfNumbersSecond[i] = random.Next(); ;
        }
        for (int i = 0; i < arrayOfNumbersSecond.Length; i++)
        {
            Console.Write(" " + arrayOfNumbersSecond[i]);
        }
        Console.WriteLine();
    }
    static void Fibon()
    {
        Console.WriteLine("F1) 1");
        Console.WriteLine("F2) 1");
        int n_1 = 1;
        int n_2 = 1;

        for (int i = 3; i <= 11; ++i)
        {
            var n_3 = n_1 + n_2;
            Console.WriteLine("F{0}) {1}", i, n_3);
            n_1 = n_2;
            n_2 = n_3;
        }
        Console.ReadKey();
    }

    static void CreatePrintArrayReplase()
    {
        Console.WriteLine("Введите размерность массива: ");
        byte count = byte.Parse(Console.ReadLine());
        Random random = new Random();
        int[] arrayOfNumbers = new int[count];

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = random.Next(); 
        }
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(" " + arrayOfNumbers[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (i % 2 == 1)
            {
                arrayOfNumbers[i] = 0;
            }
            Console.Write(" " + arrayOfNumbers[i]);
        }
        Console.WriteLine();
    }
    static void CreateAndSortArray()
    {
        string [] arrayOfSurnames = new string [5];

        for (int i = 0; i < arrayOfSurnames.Length; i++)
        {
            Console.WriteLine("Введтие фамилию: ");
            string Surname = Console.ReadLine();
            arrayOfSurnames[i] = Surname ;
        }

        Array.Sort(arrayOfSurnames);
        for (int i = 0; i < arrayOfSurnames.Length; i++)
        {
            Console.Write(" " + arrayOfSurnames[i]);
        }
        Console.WriteLine();
    }

}
