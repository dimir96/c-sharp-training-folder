﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 50, ya = 1,
    xb = 1, yb = 30,
    xc = 100, yc = 30;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");


int x = xa, y = ya;
int count = 0;
int countMAX = 10000;

while (count <countMAX)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x=(x+xa) / 2;
        y=(y+ya) / 2;
    }

    if (what == 1 )
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }

     if (what == 2 )
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}
Console.SetCursorPosition(1,yc+1);