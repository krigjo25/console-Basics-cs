namespace console_Basics_cs.lib;

public class Kalkulator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Substract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {

        return (b != 0 || a != 0 )? a / b : throw new DivideByZeroException();
    }
    public int Modulus(int a, int b)
    { 
        return (a % b != a || a%b != b) ? a % b : throw new DivideByZeroException();
    }
}