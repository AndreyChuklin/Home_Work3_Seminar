void Zadacha19()
{
    //Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    Console.WriteLine("Введите пятизначное число ");
    string num = Console.ReadLine();


    if (num[0] == num[4] && num[1] == num[3] && num.Length == 5)
    {
        Console.WriteLine("Введеное число является палиндромом ");
    }
    else
    {
        Console.WriteLine("Введеное число не является палиндромом ");
    }


}



void Zadacha21()
{
    //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    Console.WriteLine("Ввдедите координаты первой точки");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввдедите координаты второй точки");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());
    double z2 = Convert.ToInt32(Console.ReadLine());

    double xx = x2 - x1;
    double yy = y2 - y1;
    double zz = z2 - z1;


    double result = Math.Sqrt(xx * xx + yy * yy + zz * zz);
    result = Math.Round(result, 2); //задаем, сколько знаков после запятой будет показано
    Console.WriteLine("Расстояние:" + result);



}


void Zadacha23()
{
    //Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;

    while (count <= number)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }

}
//Zadacha19();
//Zadacha21();
Zadacha23();