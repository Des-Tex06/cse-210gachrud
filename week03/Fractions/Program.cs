using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        //Console.WriteLine(fract1.GetTop());
        //Console.WriteLine(fract1.GetBottom());
        fract1.GetFractionString();
        Console.WriteLine(fract1.GetDecimalValue());

        Fraction fract2 = new Fraction(5);
        //Console.WriteLine(fract2.GetTop());
        //Console.WriteLine(fract2.GetBottom());
        fract2.GetFractionString();
        Console.WriteLine(fract2.GetDecimalValue());

        Fraction fract3 = new Fraction(3,4);
        //Console.WriteLine(fract3.GetTop()); 
        //Console.WriteLine(fract3.GetBottom());
        fract3.GetFractionString();
        Console.WriteLine(fract3.GetDecimalValue());

        Fraction fract4 = new Fraction(1,3);
        fract4.GetFractionString();
        Console.WriteLine(fract4.GetDecimalValue());


        

    }
}