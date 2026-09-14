using System;

public class Enum
{
    enum Month
    {
        Jan,
        Fab,
        March,
        April,
        May
    }
    public static void enumExe1()
    {
        Month my_mon;
        Month cur_mon;

        my_mon = Month.Jan;
        cur_mon = (Month)3;
        Console.WriteLine("달력의 월: {0}, 현재 월: {1}", my_mon, cur_mon);
        Console.WriteLine("세팅된 월 숫자 {0}", (int)my_mon);
        Console.WriteLine("현재 월 숫자 {0}", (int)cur_mon);
    }
}