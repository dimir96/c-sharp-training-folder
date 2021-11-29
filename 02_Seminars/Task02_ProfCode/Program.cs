// Задача 2
// Задать положительное вещественное число m. Cоставить целое число n из цифр

// десятков и сотых m
// единиц и сотых m
// сотен и десятых m

double GetNumber()
    {
        Console.Write("Введите положительное вещественное число m: ");
        double number = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
        return number;
    }
int LastDigit(double n)
    {
        int lastdigit = (Convert.ToInt32(n) % 10);
        return lastdigit;
    }
int MakeTwoDigitNumber(int firstdigit, int seconddigit)
    {
        int number = firstdigit*10 + seconddigit;
        return number;
    }

Console.Clear();
double m=(GetNumber());
Console.Write("число n из десятков и сотых m: ");
Console.WriteLine(MakeTwoDigitNumber(LastDigit(m/10),LastDigit(m*100)));

Console.Write("число n из единиц и сотых m: ");
Console.WriteLine(MakeTwoDigitNumber(LastDigit(m),LastDigit(m*100)));

Console.Write("число n из сотен и десятых m: ");
Console.WriteLine(MakeTwoDigitNumber(LastDigit(m/100),LastDigit(m*10)));