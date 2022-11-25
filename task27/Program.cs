/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
    
int number = getNumberFromUser("Введите число");
    int sum = number % 10;
    while (number > 0)
    {
        number = number / 10;
        int digit = number % 10;
        sum = sum + digit;
    }
Console.WriteLine($"Сумма цифр в числе = {sum}");

