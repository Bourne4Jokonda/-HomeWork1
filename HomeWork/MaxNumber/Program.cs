//Выясняем максимальное число из трех

Console.WriteLine("Чтобы узнать наибольшее число, введите 3 числа ");
Console.WriteLine("Сейчас первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Сейчас второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Сейчас третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("Наибольшее число это - ");
Console.WriteLine(max);