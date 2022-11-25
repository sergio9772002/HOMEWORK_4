/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*int sumOfDigits(int start, int finish)
{
    int digit1 = 
    int sum = 0;
    while ()
    {
        sum += i; // sum = sum + i;
    }
    return sum;
}
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
for (int i = 0; i < length; i++)
{
    int sum = getNumberFromUser % 10;
    while (Digit < 0)
    {
        Digit = Digit / 10;
        sum = sum + Digit;
    }

}

int userNumber = getNumberFromUser("Введите число");
int sum = sumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1...{userNumber} = {sum}");

int randomNumber = GetRandomNumberInRange(1, 100000);
Console.WriteLine(randomNumber);
int threetDigit = randomNumber; 
if (randomNumber > 100)
{
    while (threetDigit > 1000)
    {
        threetDigit = threetDigit / 10;
    }
int numberthree = threetDigit % 10;
Console.WriteLine($" {numberthree} ");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}