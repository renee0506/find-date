using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindDate.Objects
{
  public class FindingDate
  {
    public string FindDate(string month, string day, string year)
    {

      Dictionary<double, string> dayofweek = new Dictionary<double, string>(){{1, "Monday"}, {2, "Tuesday"}, {3, "Wednesday"}, {4, "Thursday"}, {5, "Friday"}, {6, "Saturday"}, {0, "Sunday"}};
      int[] daysinMonth = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

      int monthInt = int.Parse(month);
      double dayInt = double.Parse(day);
      int yearInt = int.Parse(year);//1999

      int yearDiff = Math.Abs(yearInt - 2000);//yearDiff = 1999-2000 = 1
      double yearDivisible100 = Math.Ceiling((double)yearDiff/100);//101/100 ==> 1.01 ==>2
      double yearDivisible400 = Math.Ceiling((double)yearDiff/400);
      double leapYear = Math.Ceiling((double)yearDiff/4);
      double daysPassedInYear = (leapYear-yearDivisible100+yearDivisible400)*366 + (yearDiff-leapYear+yearDivisible100-yearDivisible400)*365;

      double daysPassed = 0;
      if (monthInt > 1)
      {
        for (int i=1; i < monthInt; i++)
        {
          if (i == 2)
          {
            if ( (yearInt%4 == 0 && yearInt%100 != 0) || (yearInt%400 == 0) )
            {
              daysPassed = daysPassed + 29;
            }
            else
            {
              daysPassed = daysPassed + daysinMonth[i-1];
            }
          }
          else
          {
          daysPassed = daysPassed + daysinMonth[i-1];
          }
        }
      }

      double dayDiff = daysPassedInYear + daysPassed + (dayInt - 1);//366+0+0


      return dayofweek[(dayDiff+6)%7];//372%7
    }

    public string FindDateBackward(string month, string day, string year)
    {

      Dictionary<double, string> dayofweek = new Dictionary<double, string>(){{1, "Monday"}, {2, "Tuesday"}, {3, "Wednesday"}, {4, "Thursday"}, {5, "Friday"}, {6, "Saturday"}, {0, "Sunday"}};
      int[] daysinMonth = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

      int monthInt = int.Parse(month);
      double dayInt = double.Parse(day);
      int yearInt = int.Parse(year);//1995

      int yearDiff = Math.Abs(yearInt - 2000);//yearDiff = 1999-2000 = 5
      double yearDivisible100 = Math.Floor((double)yearDiff/100);//0
      double yearDivisible400 = Math.Floor((double)yearDiff/400);//0
      double leapYear = Math.Floor((double)yearDiff/4);//1 ==> 1996
      double daysPassedInYear = (leapYear-yearDivisible100+yearDivisible400)*366 + (yearDiff-leapYear+yearDivisible100-yearDivisible400)*365;//401 - 100 + 4 -1 = 304

      double daysPassed = 0;
      if (monthInt > 1)
      {
        for (int i=1; i < monthInt; i++)
        {
          if (i == 2)
          {
            if ( (yearInt%4 == 0 && yearInt%100 != 0) || (yearInt%400 == 0) )
            {
              daysPassed = daysPassed + 29;
            }
            else
            {
              daysPassed = daysPassed + daysinMonth[i-1];
            }
          }
          else
          {
          daysPassed = daysPassed + daysinMonth[i-1];
          }
        }
      }

      double dayDiff;
      if (yearDiff >400)
      {
        dayDiff = daysPassedInYear - daysPassed - (dayInt );
      }
      else
      {
        dayDiff = daysPassedInYear - daysPassed - (dayInt-1);
      }
      //1826+212+22 = 2060

      return dayofweek[6-(dayDiff%7)];//372%7


    }
  }
}

      // Dictionary<int, string> dayofweekBackward = new Dictionary<int, string>(){{3, "Monday"}, {4, "Tuesday"}, {5, "Wednesday"}, {6, "Thursday"}, {0, "Friday"}, {1, "Saturday"}, {2, "Sunday"}};
      // else
      // {
      //   double leapYear = Math.Floor((double)yearDiff/4);
      //   leapYear1 = Convert.ToInt32(leapYear);//0
      //   //365
      // }
      // else
      // {
      //   return dayofweekBackward[(dayDiff+6)%7];
      // }
