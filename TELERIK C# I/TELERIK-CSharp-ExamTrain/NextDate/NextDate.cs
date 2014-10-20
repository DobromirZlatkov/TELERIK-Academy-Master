using System;
class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int daysInMonth = 0;
        switch (month)
        {
            case 1:
                daysInMonth = 31;
                break;
            case 2:
                daysInMonth = 28;
                break;
            case 3:
                daysInMonth = 31;
                break;
            case 4:
                daysInMonth = 30;
                break;
            case 5:
                daysInMonth = 31;
                break;
            case 6:
                daysInMonth = 30;
                break;
            case 7:
                daysInMonth = 31;
                break;
            case 8:
                daysInMonth = 31;
                break;
            case 9:
                daysInMonth = 30;
                break;
            case 10:
                daysInMonth = 31;
                break;
            case 11:
                daysInMonth = 30;
                break;
            case 12:
                daysInMonth = 31;
                break;               
        }
        switch (year)
        {
            case 2000:
                if (daysInMonth == 28)
                {
                    daysInMonth++;
                }
                break;
            case 2004:
                if (daysInMonth == 28)
                {
                    daysInMonth++;
                }
                break;
            case 2008:
                if (daysInMonth == 28)
                {
                    daysInMonth++;
                }
                break;
            case 20012:
                if (daysInMonth == 28)
                {
                    daysInMonth++;
                }
                break;

        }
        if (daysInMonth == day)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            day = 1;
        }
        else
        {
            day++;
        }
        Console.WriteLine(day + "."+month +"."+year);
    }
}

