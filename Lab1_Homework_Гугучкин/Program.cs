using System;

// Console.Write("Введите первое целое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int sum = num1 + num2;
// int diff = num1 - num2;
// int prod = num1 * num2;
// double quot = (double)num1 / num2;

// Console.WriteLine(sum);
// Console.WriteLine(diff);
// Console.WriteLine(prod);
// Console.WriteLine(quot);

//2 задание

// Console.Write("Введите имя: ");
// string name = Console.ReadLine();

// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());

// Console.Write("Введите любимый язык программирования: ");
// string language = Console.ReadLine();

// Console.WriteLine($"Привет, {name}!");
// Console.WriteLine($"Тебе {age} лет.");
// Console.WriteLine($"Твой любимый язык программирования — {language}");
// //Задание 3. Квадратное уравнение
// Напишите программу, которая должна по введённым коэффициентам a, b, c
// вычислить значение выражения:

//Console.WriteLine("введите значение a: ");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("введите значение b: ");
//int b = int.Parse(Console.ReadLine());

//Console.WriteLine("введите значение c: ");
//int c = int.Parse(Console.ReadLine());

//Console.WriteLine((a * 5 * 5) + (b * 5) + c);

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите ваш город проживания: ");
        string city = Console.ReadLine();

        Console.Write("Введите ваше любимое число: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Введите температуру за окном в °C: ");
        double temperatureC = double.Parse(Console.ReadLine());

        double temperatureF = temperatureC * 9 / 5 + 32;

        Console.WriteLine("\n=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
        Console.WriteLine($"Привет, {name}!");
        Console.WriteLine($"\nВаш возраст: {age} лет");
        Console.WriteLine($"Через год вам будет: {age + 1} лет");
        Console.WriteLine($"\nВы проживаете в городе: {city}");
        Console.WriteLine($"Любимое число в квадрате: {num * num}");
        Console.WriteLine($"\nТемпература за окном: \n цельсиях {temperatureC}°C \n в фаренгейтах({temperatureF:F1}°F)");
    }
}