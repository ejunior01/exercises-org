using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        var totalLetter = statement.Where(char.IsLetter).Count();
        var yellAtHim = totalLetter > 0 & statement.Where(char.IsLetter).All(char.IsUpper);
        var question = statement.Trim().EndsWith("?");


        if (yellAtHim && question) return "Calm down, I know what I'm doing!";
        if (yellAtHim) return "Whoa, chill out!";
        if (question) return "Sure.";
        if(string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!" ;
        return "Whatever.";
    }
}