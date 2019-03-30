using System;
using System.Collections.Generic;
using System.Linq;

namespace my_where.Methods
{
  public static class ExtensionMethods
  {
    public static IEnumerable<int> MyWhere(this IEnumerable<int> list, Func<int, bool> filter)
    {
      var result = new List<int>();
      bool exit = false;
      for (int i = 0; i < list.Count(); ++i)
      {
        if (filter(list.ElementAt(i)))
        {
          result.Add(list.ElementAt(i));
        }
      }

      //   Console.WriteLine($"MyWhere filter was applyed {count} times.");
      return result;
    }
  }
}