class Conversion
{
    static void Main()
    {
        int a = 25;
        double b = (double)a;
        float c = (float)b;
        long d = (long)a;

        Console.WriteLine("int:" + a);
        Console.WriteLine("int:" + a.GetType());
        Console.WriteLine("double:" + b);
        Console.WriteLine("double:" + b.GetType());
        Console.WriteLine("float:" + c);
        Console.WriteLine("float:" + c.GetType());
        Console.WriteLine("long:" + d);
        Console.WriteLine("long:" + d.GetType());
    }
}