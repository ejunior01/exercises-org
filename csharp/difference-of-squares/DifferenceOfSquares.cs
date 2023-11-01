using System;
using System.Linq;

public static class DifferenceOfSquares
{

    public static int CalculateSquareOfSum(int max) => (int)Pow(ArithmeticProgression(1,max),2);

    public static int CalculateSumOfSquares(int max) => (int)Enumerable.Range(1,max).Select((n) => Pow(n,2)).Sum();
    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);

    private static int ArithmeticProgression(int start,int max) => (start+max)*max/2;

    private static double Pow(int value,int raised) => Math.Pow(value,raised);

}