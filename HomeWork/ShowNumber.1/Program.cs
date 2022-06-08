//Показать вторую цифру трёхзначного числа
Console.Write("Введите число ");
int A = int.Parse(Console.ReadLine());
int div = A / 10;
int simple = 1;

simple = div % 10;
Console.WriteLine(simple);