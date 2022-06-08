//Показать последнюю цифру трёхзначного числа
Console.Write("Введите число ");
int A = int.Parse(Console.ReadLine());
int simple = 1;

simple = ( A % 10);
Console.WriteLine(simple);