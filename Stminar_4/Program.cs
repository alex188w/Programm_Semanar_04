void Zadacha_24()
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
{
    Console.WriteLine("Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А");
    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine()); 
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
}

void Zadacha_26()
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
{
    Console.WriteLine("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 0;

    while (N > 0)
    {
        N = N / 10;
        i++;
    }
    Console.WriteLine($"В данном числе {i} цифр");
}

void Zadacha_28()
//Задача 28: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N
{
    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine()); 
    int product = 1;

    for (int i = 1; i <= number; i++)
    {
        product *= i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {number} равна {product}");
}

void Zadacha_30()
// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

{
    int[] massive = new int[5]; 
    int length = massive.Length;
    int index = 0;

    while (index < length)
    {
        massive[index] = new Random().Next(0, 2); 
        Console.Write(massive[index] + " ");
        index++;    
    }
}


//Zadacha_24();
// Zadacha_26();
//Zadacha_28();
Zadacha_30();