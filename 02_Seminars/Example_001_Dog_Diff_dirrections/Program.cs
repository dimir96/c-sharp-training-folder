//Задачка про друзей в разные стороны 

// count = 0, distance = 10 000 firstFriendSpeed = 5 secondFriendSpeed = 2 dogSpeed = 10 friend =2 mittingDistance = 1

// Получаем переменные 
int count = 0;
int mittingDistance = 5;
double time = 0;
Console.Write("Пожалуйста введите расстояние между друзьями [м]: ");
double distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите скорость первого друга [м/с]: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите скорость второго друга [м/с]: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста скорость собаки [м/с]: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

// Расчеты
while (distance>mittingDistance)
{
    
    if ( count % 2 == 0)
    {
        time = distance / (dogSpeed + secondFriendSpeed);
        count++;
        Console.WriteLine(distance);
    }
    else
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        count++;
        Console.WriteLine(distance);
    }


    distance = distance - time * (firstFriendSpeed + secondFriendSpeed);
}

// Выводим значение

Console.Write("Собака пробежит: ");
Console.Write(count);
Console.Write(" раз");