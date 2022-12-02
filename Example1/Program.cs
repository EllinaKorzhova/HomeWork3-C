/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите число");
String number = Console.ReadLine();

void CheckPalindrom(string num){
if (num[0]==num[4] || number[1]==num[3]) {
        Console.WriteLine($"Ваше число: {num} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
}
  if (number.Length == 5){
    CheckPalindrom(number);
  } else Console.WriteLine($"Введи правильное число");
 
