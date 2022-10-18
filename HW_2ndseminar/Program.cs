// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Clear();

// Console.WriteLine("Enter your number, please: ");
// int number = Convert.ToInt32(Console.ReadLine()); // Вариант, когда число вводится самостоятельно
// // int number = new Random().Next(1, 1000); //Варинат для случайных чисел

// Console.WriteLine($"The second digit of {number} is {number/10%10}");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Enter your number, please: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int shownumber = number;
while (number>1000)
{
    number = number/10;
}
Console.WriteLine($"The third digit of {shownumber} is {number%10}.");

// if (number<100)
// {
//     Console.WriteLine($"There is no third digit in {number}.");
// }
// else
// {
//     Console.WriteLine($"The third digit of {number} is {number.ToString()[2]}.");
// }

// или просто одной стройкой: 
//Console.WriteLine($"The third digit of {number} is {number.ToString()[2]}.");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();

// Console.WriteLine("Enter day of the week using numbers, please: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 6)
// {
//     Console.WriteLine("Sadly it's not a weekend.");
// }
// else if (number >= 8)
// {
//     Console.WriteLine($"Ooops! There are only 7 days in a week, not {number}!");
// }
// else
// {
//     Console.WriteLine("Yay! It's a weekend!!!");
// }