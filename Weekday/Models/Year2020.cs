namespace Weekday.Models
{
  public class Year2020
  {
    public int Month {get; set;}
    public int Day {get; set;}

    public Year2020 (int month, int day)
    {
      Month = month;
      Day = day;
    }

    public int GetDayNum(int month, int day)
    {
      int dayNum = 0;
      if (month == 1)
      {
        dayNum += day;
      }
      else if (month == 2)
      {
        dayNum = 31 + day;
      }
      else if (month == 3)
      {
        dayNum = 31 + 29 + day;
      }
      else if (month == 4)
      {
        dayNum = 31 + 29 + 31 + day;
      }
      else if (month == 5)
      {
        dayNum = 31 + 29 + 31 + 30 + day;
      }
      else if (month == 6)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + day;
      }
      else if (month == 7)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + 30 + day;
      }
      else if (month == 8)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + 30 + 31 + day;
      }
      else if (month == 9)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + day;
      }
      else if (month == 10)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + day;
      }
      else if (month == 11)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + day;
      }
      else if (month == 12)
      {
        dayNum = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + day;
      }
      return dayNum;
    }

    public string GetDate(int dayNum)
    {
      if (dayNum % 7 == 0)
      {
        return "Tuesday";
      }
      else if (dayNum % 7 == 1)
      {
        return "Wednesday";
      }
      else if (dayNum % 7 == 2)
      {
        return "Thursday";
      }
      else if (dayNum % 7 == 3)
      {
        return "Friday";
      }
      else if (dayNum % 7 == 4)
      {
        return "Saturday";
      }
      else if (dayNum % 7 == 5)
      {
        return "Sunday";
      }
      return "Monday";     
    }
  }
}