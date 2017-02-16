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
  }
}
