// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Семинарские примеры
Console.clear();

int n = new Random().Next(10, 100); //получаем некое рандомное число от 10 до 99
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n1)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);
*/

// Домашнее задание №10
/* Console.WriteLine("Введите трехзначное число");
int z = Convert.ToInt32(Console.ReadLine());
int n = z / 10 % 10;
Console.WriteLine(n);
*/
// Домашнее задание № 13
/* Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100){
    while (a > 999)
        a = a / 10;
    int b = a % 10;
    Console.WriteLine(b);}
else
    Console.WriteLine("Третьей цифры нет");
*/

// Домашнее задание №15
/* Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 7){
    if ( day <= 5)
        Console.WriteLine("нет");
    else
        Console.WriteLine("да");}
*/

// Дополнительная задача с сайта acmp.ru

/* int k = Convert.ToInt32(Console.ReadLine());
int max1 = k;
int max2 = 0;

while (k != 0){
    k = Convert.ToInt32(Console.ReadLine()); 
    if (max1 <= k){
        max2 = max1;
        max1 = k;
    }
        
}
Console.WriteLine(max2);
*/