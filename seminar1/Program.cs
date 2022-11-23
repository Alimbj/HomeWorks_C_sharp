//Знакомство с языком С#
//Console.Clear();
//Console.WriteLine("Hello World!");
//Console.Write("ВВедите число ");
//int n = int.Parse(Console.ReadLine()); //Ввод числа
// int n = Convert.ToInt32(Console.ReadLine()); //Другой вариант ввода числа
//Console.WriteLine(n *2);

// Задача: введено с клавиатуры N, вывести все числа от -N до N:
//Console.Write("ВВедите число ");
//int m = Convert.ToInt32(Console.ReadLine());
//for (int i = (-1) * m; i <= m; i++)
//    Console.Write($"{i} "); //Обозначение интерполяции строки знаком $ для сложных строк, таким образом выводится не просто символ i, а значение этого символа

// Домашнее задание №2
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if (n > m){
    Console.WriteLine("max=" +n);
    Console.WriteLine("min=" +m);
}
else if (m > n){
    Console.WriteLine("max=" +m);
    Console.WriteLine("min=" +n);
}
else if (n == m)
    Console.WriteLine("Числа равны");

//Домашнее задание №4
int x = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (x >= a){
    if (x >= b)
        Console.WriteLine(x);
    else if (b > x)
        Console.WriteLine(b);
}
else if (a > b)
    Console.WriteLine(a);

//Домашнее залание №6
int z = int.Parse(Console.ReadLine());
if (z == 0)
    Console.WriteLine("Это чиcло ноль");
if (z % 2 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

//Домашнее задание №8
int c = int.Parse(Console.ReadLine());
for (int i = 2; i <= c; i=i+2)
    Console.Write($"{i} ");