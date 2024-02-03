using System.Reflection;

public class OgretimElemani
{

    public int SicilNo { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool Cinsiyet { get; set; }

    public OgretimElemani()
    {
        Console.WriteLine("Ogretim Elemanı nesnesi oluşturuldu.");
    }

    public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
    {
        SicilNo = sicilNo;
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyet = cinsiyet;
    }

    public override string ToString()
    {
        return $"{SicilNo} " +
            $"{Adi} " +
        $"{Soyadi} " + string.Format(Cinsiyet == true ? "Bay" : "Bayan");
    }

    /* 
        //OgretimElemani ogrEl1 = new OgretimElemani();
        //ogrEl1.Cinsiyet = false;
        //ogrEl1.Adi = "Melike";
        //ogrEl1.Soyadi = "Sahin";
        //ogrEl1.SicilNo = 14;
        //Console.WriteLine(ogrEl1);

        //OgretimElemani ogrEl2 = new OgretimElemani()
        //{
        //    SicilNo = 14,
        //    Adi = "Melike",
        //    Soyadi = "Sahin",
        //    Cinsiyet = false
        //};
        //Console.WriteLine(ogrEl2);


        //OgretimElemani ogrEl3 = new OgretimElemani(13, "Salim ", "Can", true);
        //Console.WriteLine(ogrEl3);

        var OgretimElemanlariListesi =
            new List<OgretimElemani>()
            {
                new OgretimElemani(1,"Rayim", "Işık", false),
                new OgretimElemani(2,"Bayramcan", "Bajkan", true),
                new OgretimElemani(3,"Emir", "Şan", false),
                new OgretimElemani(4,"Zeki", "Karayüz", true),
                new OgretimElemani(5,"Emjan", "Işık", true),
            };

        //foreach (var item in OgretimElemanlariListesi)
        //{
        //    Console.WriteLine(item);
        //}
        OgretimElemanlariListesi.ForEach(item => Console.WriteLine(item));

        Console.WriteLine(new string('-',20));

        var liste2 = OgretimElemanlariListesi;
        liste2.ForEach(item => Console.WriteLine(item));

        liste2.Add(new OgretimElemani(6,"Akif","Mehmet",true));
        OgretimElemanlariListesi.RemoveAt(0);

        Console.ReadKey();
        Console.WriteLine(new string('-', 20));

        Console.WriteLine("Liste 1: ");
        OgretimElemanlariListesi.ForEach(item => Console.WriteLine(item));

        Console.WriteLine("Liste 2: ");
        liste2.ForEach(item => Console.WriteLine(item));
    */



}


