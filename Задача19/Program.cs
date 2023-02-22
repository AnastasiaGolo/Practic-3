//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int check = number.Length;

if(check == 5)
{
if(number[0] == number[4] || number[1] == number[3])
{
    Console.WriteLine("Число является палиндромом");
}

else
{
    
    Console.WriteLine("Не палиндром");
}
}


else
{
    Console.WriteLine("Не пятизначное число");
}
