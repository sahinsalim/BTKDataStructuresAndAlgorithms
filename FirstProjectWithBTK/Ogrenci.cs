public struct Ogrenci
{
    // yapılandırıcı metod CONSTRUCTOR
    public Ogrenci(int number, string name, string lastName, bool gender = true)
    {
        Number = number;
        Name = name;
        LastName = lastName;
        Gender = gender;
    }

    // property özellik tanımlama prob tab tab
    public int Number { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public bool Gender { get; set; }

    // geçersiz kılma , ezme , override
    public override string ToString()
    {
        return $"{Number} " +
            $"{Name} " +
            $"{LastName} " +
            string.Format(Gender == true? "Bay" : "Bayan");
    }

    /*
      
     private static void StructCodes()
    {
        // Struct
        Ogrenci ogr = new Ogrenci() { Number = 101, Name = "Salim", LastName = "Şahin", Gender = true };
        //Console.WriteLine($"{ogr.Number} " +
        //    $"{ogr.Name} " +
        //    $"{ogr.LastName} " +
        //    $"{ogr.Gender} ");

        // Contructor tanımlandığı için bu sınıftan nesne oluştururken direkt yazabiliyoruz.
        var ogr2 = new Ogrenci(221, "Rayim", "Isık", false);
        //Console.WriteLine($"{ogr2.Number} " +
        //    $"{ogr2.Name} " +
        //    $"{ogr2.LastName} " +
        //    $"{ogr2.Gender} ");

        var ogr3 = new Ogrenci(777, "Racit", "izm");

        //Console.WriteLine(ogr);
        //Console.WriteLine(ogr2);
        //Console.WriteLine(ogr3);

        var ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci(4, "XX", "YY"),
            new Ogrenci(5,"AA","SS",false),
            new Ogrenci() { Number = 12, Name = "As", LastName = "Sa", Gender = true }
        };

        ogrenciler.ForEach(o => Console.WriteLine(o));
    }

    */


}




