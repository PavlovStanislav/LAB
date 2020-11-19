using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Day1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class What_Day
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;
            var DaysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
       
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
            
            Console.WriteLine("{0} {1}", dayNum, monthName);
            Console.ReadKey();
        }
    }
}

