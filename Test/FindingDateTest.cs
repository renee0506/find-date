using Xunit;
using System.Collections.Generic;
using FindDate.Objects;

namespace FindDateTest
{
  public class FindingDateTest
  {
    [Fact]
    public void Date_findDay01012000_Sat()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Saturday", testFindingDate.FindDate("01", "01", "2000"));
    }

    [Fact]
    public void Date_findDay01022000_Sun()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Sunday", testFindingDate.FindDate("01", "02", "2000"));
    }

    [Fact]
    public void Date_findDay01082000_Sat()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Saturday", testFindingDate.FindDate("01", "08", "2000"));
    }

    [Fact]
    public void Date_findDay01092000_Sat()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Sunday", testFindingDate.FindDate("01", "09", "2000"));
    }

    [Fact]
    public void Date_findDay02012000_Tue()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Tuesday", testFindingDate.FindDate("02", "01", "2000"));
    }

    [Fact]
    public void Date_findDay01012001_Monday()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Monday", testFindingDate.FindDate("01", "01", "2001"));
    }

    [Fact]
    public void Date_findDay01012005_Sat()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Saturday", testFindingDate.FindDate("01", "01", "2005"));
    }

    [Fact]
    public void Date_findDay03172005_Thu()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Thursday", testFindingDate.FindDate("03", "17", "2005"));
    }

    [Fact]
    public void Date_findDay02031999_Wed()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Friday", testFindingDate.FindDate("12", "31", "1999"));
    }

    [Fact]
    public void Date_findDay08231995_Wed()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Wednesday", testFindingDate.FindDate("08", "23", "1995"));
    }

    [Fact]
    public void Date_findDay08231899_Fri()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Friday", testFindingDate.FindDate("08", "23", "1889"));
    }

    [Fact]
    public void Date_findDay02031599_Thur()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Thursday", testFindingDate.FindDate("02", "03", "1599"));
    }

    [Fact]
    public void Date_findDay08232150_Sun()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Sunday", testFindingDate.FindDate("08", "23", "2150"));
    }

    [Fact]
    public void Date_findDay08232152_Wed()
    {
      FindingDate testFindingDate = new FindingDate();
      Assert.Equal("Wednesday", testFindingDate.FindDate("08", "23", "2152"));
    }
  }
}
