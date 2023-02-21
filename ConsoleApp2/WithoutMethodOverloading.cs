namespace ConsoleApp2;

internal class WithoutMethodOverloading
{
    public static int Add1(int a, int b)
    {
        return a + b;
    }

    public static int Add2(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Add3(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
}


