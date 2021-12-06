Console.Clear();
double GetNumber()
{
    Console.Write("Введите вещественное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

double m = 0;

// Выяснить является ли вещественное m
// целой степенью числа 3
// корнем целой степени из 5,
// синусом угла кратного 45 градусам


// целой степенью числа 3

Console.WriteLine("________задача 1________");
m=GetNumber();

if (m%3==0)
{
    for (double i = 1; i < m/3; i++)
    {
        
        if(m <= Math.Pow(3,i) & Math.Pow(m,1/i)==3 ) Console.WriteLine($"Число {m} является целой степенью числа 3");
    }
    
}
else 
Console.WriteLine($"Число {m} не является целой степенью числа 3");



// корнем целой степени из 27,

Console.WriteLine("________задача 2________");
m=GetNumber();

   
for (double i = 1; i < 5; i++)
    {
        
        if( Math.Pow(m,i)==27) 
        {
            Console.WriteLine($"Число {m} является корнем целой степени из 27");
            break;
        }
    }
Console.WriteLine($"Число {m} НЕ является корнем целой степени из 27");



// синусом угла кратного 45 градусам
Console.WriteLine("________задача 3________");
m=GetNumber();
double checker = 0;
if (m>=-1 && m<=1)
{
for (int i = 0; i < 8; i++)
{
    Console.WriteLine(Math.Sin((45*i)*Math.PI/180));
    if (m==Math.Sin((45*i)*Math.PI/180))
    {
        
        Console.WriteLine($"Число {m} является синусом угла кратного 45 градусам");
        break;
    }
    
}
}
