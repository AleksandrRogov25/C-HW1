Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
// Вариант 1
// if (a > b && a > c)
// {
// Console.WriteLine($"maх = {a} ");
// }
// else
// {
//      if (b > c){
// Console.WriteLine($"maх = {b} ");
// }
//     if (c > b){
// Console.WriteLine($"maх = {c} ");
// }
// }
//Вариант 2
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"maх = {max} ");