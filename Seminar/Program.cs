/*int num = new Random().Next(1000);

string NumStr = num.ToString();
if(NumStr.Length == 3)
{
    Console.WriteLine($"Число {num} без второй цифры имеет вид {NumStr[0]}{NumStr[2]}");
}
else {
    Console.WriteLine($"Число {num} не трехзначное");

}*/

/*Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

78 -> 8

12-> 2

85 -> 8*/

int num = new Random().Next (10,100);
string NumStr = num.ToString();
if (NumStr.Length == 2) 
{
    Console.WriteLine ($" Ваше первое число {NumStr[0]} Ваше второе число {NumStr[1]}");
    if (NumStr[0] > NumStr [1]){
        Console.WriteLine ($"Наибольшее число {NumStr[0]}");
    }
    else {
        Console.WriteLine ($"Наибольшее число {NumStr[1]}");
    }
}




/*Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно*/

