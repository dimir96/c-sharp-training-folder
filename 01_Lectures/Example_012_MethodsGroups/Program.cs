Console.Clear();
// //Виды методов 

// // Вид 1
// void Method1()
// {
//    Console.WriteLine("Автор программы ... ");
// }
// // Method1();









// // Вид 2
// void Method2(string msg)
// {
//    Console.WriteLine(msg);
// }

// // Method2(msg: "текст сообщения");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(msg: "Text", count:4);
// // Method21(count:4, msg: "New text");







// // Вид 3
// int Method3()
// {

//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);







// Вид 4

// string Method4(int count, string text)
// {
//     int i=0;
//     string result = String.Empty;

//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);




// ЦИКЛ ФОР
// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for(int i = 0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);





//ЦИКЛ В ЦИКЛЕ 
for( int i = 2; i<=10; i++)
{
    for (int j =0; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}