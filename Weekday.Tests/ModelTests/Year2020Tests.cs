using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weekday.Models;

namespace Weekday.Tests
{
  [TestClass]
  public class Year2020Tests
  {
    [TestMethod]
     public void Year2020Constructor_CreateInstanceOfYear2020_Year2020()
    {
      Year2020 newYear2020 = new Year2020(3, 4);
      Assert.AreEqual(typeof(Year2020), newYear2020.GetType());
    }

  [TestMethod]
  public void GetDayNum_GetDayNumberForJan_DayNum()
  {
    Year2020 newYear2020 = new Year2020(1, 4);
    int result = newYear2020.GetDayNum(1, 4);
    Assert.AreEqual(4, result);
  }

  [TestMethod]
  public void GetDayNum_GetDayNumberForFeb_DayNum()
  {
    Year2020 newYear2020 = new Year2020(2, 4);
    int result = newYear2020.GetDayNum(2, 4);
    Assert.AreEqual(35, result);
  }

  [TestMethod]
  public void GetDayNum_GetDayNumberForDec_DayNum()
  {
    Year2020 newYear2020 = new Year2020(12, 4);
    int result = newYear2020.GetDayNum(12, 4);
    Assert.AreEqual(339, result);
  }


    [TestMethod]
    public void GetDate_CheckIsTue_Tue()
    {
      Year2020 newYear2020 = new Year2020(1, 7);
      string result = newYear2020.GetDate(7);
      Assert.AreEqual("Tuesday", result);
    }

    [TestMethod]
    public void GetDate_CheckIsTue_Wed()
    {
      Year2020 newYear2020 = new Year2020(3, 4);
      string result = newYear2020.GetDate(64);
      Assert.AreEqual("Wednesday", result);
    }

    [TestMethod]
    public void GetDate_CheckIsTue_Mon()
    {
      Year2020 newYear2020 = new Year2020(3, 9);
      string result = newYear2020.GetDate(69);
      Assert.AreEqual("Monday", result);
    }
  }
}