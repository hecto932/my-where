using System;
using System.Collections.Generic;
using System.Linq;

namespace my_where.Methods
{
    public static class ExtensionMethodMyWhere
    {
        public static IEnumerable<int> MyWhere(this IEnumerable<int> list, Func<int, bool>  IsEven, int apply = 0) {
            var result = new List<int>();
            int count = 0;
            bool exit = false;
            for(int i = 0; i < list.Count() && !exit; ++i) 
            {
                if (IsEven(list.ElementAt(i))) {
                    result.Add(list.ElementAt(i));
                    count++;
                    if (apply != 0 && (count == apply)) {
                        exit = true;
                    }
                }
            }

            Console.WriteLine($"MyWhere filter was applyed {count} times.");
            return result;
        }
    }
}