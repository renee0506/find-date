using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindDate.Objects
{
  public class FindingDate
  {
    public string FindDate(string month, string day, string year)
    {
      Dictionary<int, string> dayofweek = new Dictionary<int, string>(){{1, "Monday"}, {2, "Tuesday"}, {3, "Wednesday"}, {4, "Thursday"}, {5, "Friday"}, {6, "Saturday"}, {0, "Sunday"}};
      int[] daysinMonth = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      int monthInt = int.Parse(month);
      int dayInt = int.Parse(day);
      int yearInt = int.Parse(year);
      int yearDiff = yearInt - 2000;//yearDiff = 2001-2000 = 1
      double leapYear = Math.Ceiling((double)yearDiff/4);
      int leapYear1 = Convert.ToInt32(leapYear);//leapYear = ceil(1/4) = 1
      int daysPassedInYear = leapYear1*366 + (yearDiff-leapYear1)*365;//1*366+(1-1)*365 = 366
      int daysPassed = 0;
      if (monthInt > 1)
      {
        for (int i=1; i < monthInt; i++)
        {
          daysPassed = daysPassed + daysinMonth[i-1];
        }
      }
      int dayDiff = daysPassedInYear + daysPassed + (dayInt - 1);//366+0+0
      return dayofweek[(dayDiff+6)%7];//372%7

    }
  }
}
