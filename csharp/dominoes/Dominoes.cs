using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {

        if (!dominoes.Any())
            return true;

        if (dominoes.Count() == 1)
        {
            return dominoes.First().Item1 == dominoes.First().Item2;
        
        };

        return false;
    }
}