using System;
using System.Collections.Generic;
using System.Linq;
using my_where.Methods;

namespace my_where
{
  class Program
  {
    static void Main(string[] args)
    {
      // Utilizando LINQ, generar una lista de los números del 1 al 1000.
      var numberList = Enumerable.Range(1, 1000).ToList();
      Console.WriteLine($"numberList created with {numberList.Count} int elements...");

      // Filtra la lista de números, tomando solo los que son pares
      var evenList = numberList.Where(e => e % 2 == 0);
      Console.WriteLine($"Filtering all the even numbers using where function from linq...");

      // Imprime solo los 3 primeros números de la lista de valores pares. (debe mostrar 2,4,6)
      Console.WriteLine($"Printing the first three numbers...");
      printList(evenList, 3);

      // A partir de este momento ya no puedes usar Where de LINQ;
      // reemplázala por un extension method local equivalente en funcionalidad. i.e. numeros.Where(...) ahora debe leerse como numeros.MyWhere(...)
      // Dentro de la nueva implementación de MyWhere, haz un conteo de la cantidad de números sobre los cuales se ejecutó el filtro.
      var evenListMyWhere = numberList.MyWhere(e => e % 2 == 0);

      // print the first 3 numbers
      printList(evenListMyWhere);

    }

    private static void printList(IEnumerable<int> list, int limit = 0)
    {
      limit = limit == 0 ? list.Count() : limit;
      for (int i = 0; i < limit; i++)
      {
        Console.WriteLine(list.ElementAt(i));
      }
    }
  }
}
