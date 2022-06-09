//Удаляем вторую цифру трехзначного числа и выводим двухзначное
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int A1 = 0;
int A3 = 0;
int div1 = number % 10;
int div3 = (number / 100) % 10;
int sum = 0;

A1 = div1;
A3 = div3;
sum = (A3 * 10) + A1;

Console.WriteLine(sum);