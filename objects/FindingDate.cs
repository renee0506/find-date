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
      int daysPassed = 0;
      if (monthInt > 1)
      {
        for (int i=1; i < monthInt; i++)
        {
          daysPassed = daysPassed + daysinMonth[i-1];
        }
      }
      int dayDiff = daysPassed + (dayInt - 1);
      return dayofweek[(dayDiff+6)%7];

    }
  }
}
