public struct Nokta
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"{X}, {Y}";
    }

    // default ctor
    public Nokta(int x, int y)
    {
        X= x ;
        Y= y ;
    }

    //yeni üye metot

    public void SetOrigin()
    {
        X = 0 ;
        Y = 0 ;
    }

    public void Degistir()
    {
        var gecidi = X;
        X = Y;
        Y = gecidi ;
    }

    /*
    Nokta n1 = new Nokta(3, 7);
    Console.WriteLine(n1);

        //n1.Degistir();
        //Console.WriteLine(n1);

        //n1.SetOrigin();
        //Console.WriteLine(n1);


        var n2 = n1;
    n2.X = -1 * n2.X;

        Console.WriteLine($"n1: {n1}");
        Console.WriteLine($"n2: {n2}");
        Console.ReadKey();
    */


}


