// Задача 1
// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые

// 1.1 делятся на k, но не на l
// 1.2 делятся хотябы на k или на l
// 1.3 не делятся на (k + l)
int GetNumber()
    {
        
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

Console.Clear();
Console.WriteLine("Введите заданное число n ");
int n=GetNumber();
Console.WriteLine("Введите первый делитель l ");
int k=GetNumber();
Console.WriteLine("Введите второй делитель k ");
int l=GetNumber();

int i = 1;
int count = 0;
//Задача 1.1

// while (i<=n)
// {
    
//     if (i%k==0 && i%l>0)
//     {
//        count=count+1;
//     }
//     i++;
// }
// Console.Write("Количество чисел которые делятся на k, но не на l: ");
// Console.Write(count);


//Задача 1.2
// Console.WriteLine("");
// while (i<=n)
// {
    
//     if (i%k==0 | i%l==0)
//     {
//         count=count+1;
//     }
//     i++;
// }
// Console.Write("Количество чисел которые делятся делятся хотябы на k или на l: ");
// Console.Write(count);


//Задача 1.3
Console.WriteLine("");
while (i<=n)
{
    
    if (i%(k+l)>0)
    {
        count=count+1;
        
    }
    i++;
}
Console.Write("Количество чисел которые не делятся на (k + l): ");
Console.Write(count);