using System;

class Sad
{
    static Random random = new Random();

    static int[] generateArray(int arraySize, int minValue, int maxValue, Random random)
    {
        int[] numbers = new int[arraySize];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(minValue, maxValue);
        }

        return numbers;
    }

    static void showArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static (int min, int max) find(int[] array)
    {
        int min = array[0];
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return (min, max);
    }

    static void Main(string[] args)
    {
        int[] list = generateArray(100, 100, 901, random);

      
        Console.Write("Числа більше 500: ");
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] > 500)
            {
                Console.Write(list[i] + " ");
            }
        }

       
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum += list[i];
        }
        Console.WriteLine("\nСума всіх чисел масиву: " + sum);

        
        Console.Write("Числа кратні 5: ");
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] % 5 == 0)
            {
                Console.Write(list[i] + " ");
            }
        }

        var (min, max) = find(list);
        Console.WriteLine("");
        Console.WriteLine("Найменше число:" + min);
        Console.WriteLine("Найбільше число:" + max);


        int count = 0;
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] >= 500 && list[i] <= 600)
            {
                count++;
            }
        }
       
        Console.WriteLine("Числа в межах вiд 500 до 600: " + count);

    }
}
