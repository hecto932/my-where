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
      
      foreach (int n in list.Take(6).ToList())
      {
          if (filter(n)) {
            result.Add(n);
          }
      }
      
      return result;
    }
  }
}