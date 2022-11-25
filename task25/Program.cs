/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int userNumber1 = new int();
Console.WriteLine("Введите первое число A");
userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = new int();
Console.WriteLine("Введите второе число B");
userNumber2 = Convert.ToInt32(Console.ReadLine());
int st = userNumber1;
for (int i = 0; i < userNumber2 - 1; i++)
{
    st *= userNumber1;    
}
Console.WriteLine(st);