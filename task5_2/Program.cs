


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
        var (min, max) = find(list);
        Console.WriteLine($"Найменше число: {min}");
        Console.WriteLine($"Найбільше число: {max}");

        
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum += list[i];
        }

        Console.Write("Числа кратні п'яти: ");
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] % 5 == 0)
            {
                Console.Write(list[i] + " ");
            }
        }

        Console.Write("\n Числа більше 500: ");
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] > 500)
            {
                Console.Write(list[i] + " ");
             
            }
        }
        
        int count = 0;

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] >= 500 && list[i] <= 600)
            {
                count++;
              
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Числа в межах вiд 500 до 600: " + count);






        Console.WriteLine("Сумма всіх чисел масива: " + sum);
    }

}