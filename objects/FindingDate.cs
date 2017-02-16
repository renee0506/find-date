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
      int monthInt = int.Parse(month);
      int dayInt = int.Parse(day);
      int yearInt = int.Parse(year);
      int dayDiff = dayInt - 1;
      return dayofweek[(dayDiff+6)%7];
    }
  }
}
