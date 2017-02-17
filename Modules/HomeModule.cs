using Nancy;
using System;
using System.Collections.Generic;
using FindDate.Objects;

namespace FindDateeModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ => {
        FindingDate newDate = new FindingDate();
        string month = Request.Form["user-month"];
        string dayInput = Request.Form["user-day"];
        string year = Request.Form["user-year"];
        Console.WriteLine(month);
        Console.WriteLine(dayInput);
        Console.WriteLine(year);
        string day = newDate.FindDate(month, dayInput , year);
        return View["result.cshtml", day];
      };
    }
  }
}
