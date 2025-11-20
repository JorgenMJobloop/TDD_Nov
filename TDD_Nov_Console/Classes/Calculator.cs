public class Calculator
{
    public double A;
    public double B;

    public Calculator(double a, double b)
    {
        A = a;
        B = b;
    }

    public double Add()
    {
        return A + B;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by 0");
        }
        return a / b;
    }
}