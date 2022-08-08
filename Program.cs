Console.Clear();
// // 2. Задача на квадрат числа
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Квадрат числа " + number +" = "+ number*number);

// // int result = Convert.ToInt32(Math.Pow(number, 2));
// // Console.WriteLine("Квадрат числа = " + result);

//3. На вход принимает 2 числа и проверяет, является ли первое число квадратом второго

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b * b) Console.WriteLine(a + " является квадратом числа " + b);
// else Console.WriteLine(a + " не является квадратом числа" + b);

// 4. программа которая выдает название для недели по заданному номеру
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber == 1) System.Console.WriteLine("Понедельник");
// if (dayNumber == 2) System.Console.WriteLine("Вторник");
// if (dayNumber == 3) System.Console.WriteLine("Среда");
// if (dayNumber == 4) System.Console.WriteLine("Четверг");
// if (dayNumber == 5) System.Console.WriteLine("Пятница");
// if (dayNumber == 6) System.Console.WriteLine("Суббота");
// if (dayNumber == 7) System.Console.WriteLine("Воскресенье");
// if (dayNumber > 7) System.Console.WriteLine("Такого дня нет");
// if (dayNumber < 1) System.Console.WriteLine("Такого дня нет");

// 5. Напишите программу, которая на вход принимает число N, а на выходе показывает все целые числа в промежутке от -N до N. 
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int negativeNumber = number * (-1);
if (number < 0)
{
    int res = number;
    number = negativeNumber;
    negativeNumber = res;
}
while (negativeNumber <= number)
{
    Console.Write(negativeNumber + " ");
    negativeNumber++;
}
