using System;
using System.Collections.Generic;
using System.Linq;


public static class Dominoes
{

    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (dominoes.Count() == 1)
        {
            var domainItem = dominoes.First();
            return domainItem.Item1 == domainItem.Item2;
        }

        dominoes = dominoes.OrderBy(x => x.Item1);
        Console.WriteLine(dominoes);
        return true;
    }
}