Console.Clear();

// Задача 3
// Написать программу, вычисляющую значение периодической функции f(x), в произвольной точке x, если на промежутке [a;b], который составляет один её период, значения функции вычисляются по формуле

// [-3; 3], f(x) = |x| - 1
// [-10; -2], f(x) = 1/x + 0.6
// [-4; 3], f(x) = Cos(|π*x|)
double Random (int min, int max)
    {
       int number = new Random().Next(min,max+1);
       Console.WriteLine($"Искомый x: {number}");
       
       return number;
    }

// [-3; 3], f(x) = |x| - 1

double x1 = Random(-3,3);
double result1 = Math.Abs(x1) - 1;
Console.WriteLine($"Результат f({x1}) = |{x1}| - 1 = {result1}");

Console.WriteLine();

// [-10; -2], f(x) = 1/x + 0.6
double x2 = Random(-10,-2);
double result2 = (1/x2) + 0.6;
Console.WriteLine($"Результат f({x2}) = 1/{x2} + 0.6 = {result2}");

Console.WriteLine();

// [-4; 3], f(x) = Cos(|π*x|)
double x3 = Random(-4,3);
double result3 = Math.Cos(Math.Abs(Math.PI*x3));
Console.WriteLine($"Результат f({x3}) = Cos(|π*{x3}|) = {result3}");

// ИСПРАВИТЬ ЗАДАЧИ 