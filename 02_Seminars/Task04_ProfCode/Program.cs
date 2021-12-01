Console.Clear();

// Задача 4
// Даны координаты концов двух отрезков [a; b], [c; d]. Верно ли, что

// отрезки не пересекаются
// отрезки пересекаются строго в одной точке
// один отрезок вложен в другой

void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
int[] CreateArray (int min, int max)
    {
       int[] array = new int[max-min+1]; 
       array[0]=min;
        for (int i = 1; i < max-min+1; i++)
        {
            array [i]=min+i;
        }
        return array;
    }


int[] array1 = CreateArray(2,3);
int[] array2 = CreateArray(1,5);


PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

// отрезки не пересекаются

bool flag = true;
if(array1[0] > array2[array2.Length-1] | array1[array1.Length-1] < array2[0]) flag = false;
if (flag == false) Console.WriteLine("1 -- Отрезки не пересекаются");

else
Console.WriteLine("1 -- Отрезки пересекаются");


Console.WriteLine();

// отрезки пересекаются строго в одной точке

flag = false;
if(array1[0]== array2[array2.Length-1] | array2[0]== array1[array1.Length-1]) flag = true;
if (flag == true) Console.WriteLine("2 -- Oтрезки пересекаются строго в одной точке");
else
Console.WriteLine("1 -- Oтрезки НЕ пересекаются строго в одной точке");

Console.WriteLine();

// один отрезок вложен в другой

flag = false;
if( (array1[0] > array2[0] & array1[array1.Length-1] < array2[array2.Length-1]) | 
    (array1[0] < array2[0] & array1[array1.Length-1] > array2[array2.Length-1])) flag = true;
if (flag == true) Console.WriteLine("3 -- Один отрезок вложен в другой");
else
Console.WriteLine("3 -- Один отрезок НЕ вложен в другой");
