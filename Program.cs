// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int number1 = (number / 100) * 100;
int number3 = number % 10;
int number2 = (number - number1 - number3) / 10;

Console.Write("Результат: " + number2 + "- вторая цифра заданного числа" + number);


/Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:  ");

int a = int.Parse(Console.ReadLine());
string num=a.ToString();
if (a<100)
{
    Console.WriteLine(a + " нет третьей цифры ");
}
else if (a>99)
{
    Console.WriteLine( a+ "третья цифра >>" + num[2]);
}



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int number =0;

while(number <1 || number >=8)
{
    Console.WriteLine("Введите число от 1 до 7:  ");
    number = int.Parse(Console.ReadLine());
}
if(number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else    
{
    Console.WriteLine("Нет")
}