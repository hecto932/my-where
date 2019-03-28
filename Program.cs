using System;
using System.Collections.Generic;
using System.Linq;

namespace my_where
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

			// number list 1 to 1000
      var listRandomNumbers = Enumerable.Range(1, 1000).ToList();

			// eventList
			var eventList = listRandomNumbers.Where(e => e % 2 == 0);

			// print the first 3 numbers
			for (int i = 0; i < 3; i++)
			{
					Console.WriteLine(eventList.ElementAt(i));
			}
    }
  }
}
