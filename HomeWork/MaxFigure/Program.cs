//Показать наибольшую цифру двузначного числа
Console.WriteLine("Случайное двузначное число ");
int number = new Random().Next(10, 99);
int A1 = (number % 100 - number % 10) / 10;
int A2 = number % 10;
Console.WriteLine(number);
Console.WriteLine("Первая цифра двузначного числа: "+ A1);
Console.WriteLine("Вторая цифра двухзначного числа: " + A2);

if(A1>A2)
{
    Console.WriteLine("Первая цифра двухзначного числа больше второго");
}
 
if(A1<A2)
{
    Console.WriteLine("Вторая цифра двухзначного числа больше первого");
}

if(A1==A2)
{
Console.WriteLine("Цифры двухзначного числа равны");
}