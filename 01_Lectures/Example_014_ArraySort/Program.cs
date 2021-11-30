Console.Clear();

int [] arr = {4,5,6,7,8,7,6,4,9,10};

// void PrintArray (int[] array)
// {
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) 
//             {
//                 minPosition = j;
//             }
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);

// SelectionSort(arr);

// PrintArray(arr);

//Домашняя работа --------- упорядочивание по убыванию 

void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }

void SortFromMax (int[] array)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            int maxPosition = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] > array[maxPosition]) maxPosition = j;
            }


            int temporary = array [i];
            array[i]=array [maxPosition];
            array[maxPosition]=temporary;
        }
    }

PrintArray(arr);
Console.WriteLine();
SortFromMax(arr);

PrintArray(arr);