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

    static (int arraySize, int minValue, int maxValue) User()
    {
        Console.WriteLine("Введiть довжину масиву");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введiть мiнiмальне значення");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введiть максимальне значення");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        return (arraySize, minValue, maxValue);
    }

    static void Main(string[] args)
    {
        var (arraySize, minValue, maxValue) = User();

        int[] generatedArray = generateArray(arraySize, minValue, maxValue, random);

        Console.Write("Згенерований масив => ");
        showArray(generatedArray);
    }
}

/*

int[] numbers = { 678, 465, 345, 788, 234, 678, 234, 546, 234, 980 };

            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[9]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[6]);

            int[] list = generateArray(900, 10, 90, random);

            //showArray(list);

            int sum = 0;
            for (int i = 0; i < list.Length; i++) {
                sum += list[i];
            }

            Console.Write("Числа кратні семи: ");
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 7 == 0)
                {
                    Console.Write(list[i] + " ");
                }
            }

            Console.Write("\n Числа більше 80: ");
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > 80)
                {
                    Console.Write(list[i] + " ");
                }
            }

            Console.Write("\nЧисла кратні семи та більше 60 і не більше 10 штук: ");
            int count = 1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 7 == 0 && list[i] > 60 && count <= 10)
                {
                    Console.Write(list[i] + " ");
                    count++;
                }
            }


            Console.WriteLine("\nСумма всіх чисел масива: " + sum);

            /*int num = 5;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = num;
                num++;
            }

            showArray(numbers);*/




   /* static Random random = new Random();


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


    static void Main(string[] args)
    {
   */



























    






    
     
     
     
     
  
  /*  static int masiv()
    {

        Random random = new Random();
        return random.Next(1, 4);
    }

    static void Main(string[] args)
    { */
