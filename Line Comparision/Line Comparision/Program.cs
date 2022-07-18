class LineComparision
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Value X1");
        int X1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value Y1");
        int Y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value X2");
        int X2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value Y2");
        int Y2 = Convert.ToInt32(Console.ReadLine());

        double Length = Math.Sqrt((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2);
        Console.WriteLine("Length of line is: " + Length);

    }


}
