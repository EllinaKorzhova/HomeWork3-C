/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/


    Console.WriteLine("Введите число");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);

       if (number > 0) {
   for (int i = 1; i <= number; i++ ){
    Console.WriteLine($" {Math.Pow(i,3)}");
}
    } else {
        Console.WriteLine("Вы ввели число меньше 1");
    }
