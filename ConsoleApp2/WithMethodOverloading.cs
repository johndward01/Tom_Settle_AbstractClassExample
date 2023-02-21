namespace ConsoleApp2;
internal class WithMethodOverloading
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Add(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
}


