Console.Clear();
int count = 0;
// Задача 5
// Проверить, что натуральное число m

// является счастливым пятизначным
// образовано тремя цифрами, составляющими арифметическую прогрессию
// образовано четырмя одинаковыми цифрами

string GetNumber()
{
    Console.Write("Введите пятизначное целое число: ");
    return Console.ReadLine(); 
}
int [] StringToArray(string number)
{
    int[] array = new int[number.Length];
    for (int i = 0; i < number.Length; i++)
    {
        char ch = number[i];
        int bar = ch - '0';
        array[i] = bar;
    }
    return array;
}

string num = GetNumber();
int [] array = StringToArray(num);


// является счастливым пятизначным



// образовано тремя цифрами, составляющими арифметическую прогрессию



int EqualNumber (int num, int[] array)
{
    int checker = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]==num) 
        {
            checker = 1;
        }
       
    }
    return checker;

}



Console.WriteLine(String.Join('-',array));

for (int i = 0; i < 3; i++)  // Для цифр могут впринципе быть только арифметичексие прогрессии с увеличением максимум на 3 (это и запишем)
{
   for (int j = 0; j < array.Length; j++) //Здесь мы щелкаем все числа в массиве 
   {
       count=0;
       if (array[j]<9-i*2) 
       {
           for (int x = 0; x < 3; x++) //А здесь щелкаем три числа из которых по условию состоит прогрессия. 
           {
            count = count + EqualNumber(array[j]+i*x, array);  
            Console.WriteLine (count);
           }
       }
       if (count == 3) break;
   }
   if (count == 3) break;
}
if(count == 3 ) Console.WriteLine($"2-- Число {num} образовано тремя цифрами, составляющими арифметическую прогрессию.");

else 
Console.WriteLine($"2-- Число {num} НЕ образовано тремя цифрами, составляющими арифметическую прогрессию.");



// образовано четырмя одинаковыми цифрами
count=0;
for (int i = 0; i < num.Length; i++)
{
    count =0;
    for (int j = 0; j < num.Length; j++)
    {
        if(num[i]==num[j]) count = count + 1;
        
    }
    if(count == 4 ) break;
}

if(count == 4 ) Console.WriteLine($"3-- Число {num} образовано четырмя одинаковыми цифрами.");

else 
Console.WriteLine($"3-- Число {num} НЕ образовано четырмя одинаковыми цифрами.");

