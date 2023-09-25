Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int number1 = 1;
while (number1 <= number)
{
    if (number1 % 2 == 0)
Console.Write(number1 + ", "); 
number1++;
}
}
else
{
Console.WriteLine("Введите положительное число!");
}

