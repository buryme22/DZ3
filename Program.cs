// Console.WriteLine("Введите пятизначное число: ");

// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num/10000;
// int num2 = num%10000/1000;
// int num3 = num%100/10;
// int num4 = num%10;

// if (num1 == num4 && num2 == num3) {
//     Console.WriteLine($"Число является палиндромом");
// }
// else Console.WriteLine($"Число не палиндром");




double Rast(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

try
{
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите координаты z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine(Rast(x1, x2, y1, y2, z1, z2));
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
}