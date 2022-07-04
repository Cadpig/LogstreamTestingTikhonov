using System;

namespace Task1
{
    public class Program
    {
        public bool leapYear(int year)
        {
            if (year <= 0)
                throw new ArgumentOutOfRangeException(nameof(year));
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                return true;
            else
                return false;
        }
        public static int Main()
        {
            return 0;
        }
    }

}
