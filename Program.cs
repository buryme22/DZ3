Console.WriteLine("Введите пятизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10000;
int num2 = num%10000/1000;
int num3 = num%100/10;
int num4 = num%10;

if (num1 == num4 && num2 == num3) {
    Console.WriteLine($"Число является палиндромом");
}
else Console.WriteLine($"Число не палиндром");


