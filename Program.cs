// выдает вторую цифру из введенного трёхзначного число
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

string SecondNum(int num1)
{
if (num1 <= 99 || num1 > 999) 
{
return "Вы ввели НЕ трехзначное число";
}
else
return $"Вторая цифра в числе {num1%100/10-num1%10/10}";
}
Console.WriteLine(SecondNum(num));
