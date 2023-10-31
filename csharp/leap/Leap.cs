using System;

public static class Leap
{
    public static bool IsLeapYear(int year) => IsDivisibleByFour(year) && !IsDivisibleByHundred(year) || IsDivisibleByFourHundred(year);

    private static bool IsDivisibleByFour(int year) => year % 4 == 0;
    private static bool IsDivisibleByHundred(int year) => year % 100 == 0;
    private static bool IsDivisibleByFourHundred(int year) => year % 400 == 0;


}