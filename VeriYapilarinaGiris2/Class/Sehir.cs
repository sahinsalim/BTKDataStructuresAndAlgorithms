namespace VeriYapilarinaGiris2.Class
{
    public class Sehir : IComparable<Sehir>
    {

        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }


        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public int CompareTo(Sehir? other)
        {
            if (PlakaNo < other.PlakaNo)
                return -1;
            else if (PlakaNo == other.PlakaNo)
                return 0;
            else
                return 1;
        }

        public override string ToString()
        {
            return $"{PlakaNo,-3}" +
                $"{SehirAdi,-15}";
        }


        private static void ListAndIComparable()
        {
            // List & IComparable
            var sayilar = new List<int>() { 3, 5, 89, 12, 55, 21, 61, 43 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(55,"Samsun"),
                new Sehir(34,"İstanbul"),
                new Sehir(29,"Gümüşhane"),
                new Sehir(61,"Trabzon"),
            };
            sehirler.Add(new Sehir(1, "Adana"));

            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }


    }
}
