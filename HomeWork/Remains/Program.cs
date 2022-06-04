//Задание по выяснению кратное ли число заданному и если нет то какой остаток

Console.WriteLine("Выясним кратное ли первое число второму ");
Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine());
int div = A / B;
int remains = (A % B);

if ( remains == 0)
{
    Console.WriteLine("Да, число кратное");
}

else
{
    Console.Write("Остаток ");
    Console.WriteLine(div);
} 