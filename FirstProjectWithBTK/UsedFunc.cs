


using System.Collections;

internal class UsedFunc 
{
    private static void MinMaxTypesValues()
    {
        // 8-bit integer
        Console.WriteLine(nameof(SByte));
        Console.WriteLine(SByte.MinValue);
        Console.WriteLine(SByte.MaxValue);
        Console.WriteLine(sizeof(SByte));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();


        // Unsigned 8-bit integer
        Console.WriteLine(nameof(Byte));
        Console.WriteLine(Byte.MinValue);
        Console.WriteLine(Byte.MaxValue);
        Console.WriteLine(sizeof(Byte));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();


        // 16-bit integer
        Console.WriteLine(nameof(Int16));
        Console.WriteLine(Int16.MinValue);
        Console.WriteLine(Int16.MaxValue);
        Console.WriteLine(sizeof(Int16));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();

        // Unsigned Int16 işaretsiz
        Console.WriteLine(nameof(UInt16));
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
        Console.WriteLine(sizeof(UInt16));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();


        // Signed Int32
        Console.WriteLine(nameof(Int32));
        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);
        Console.WriteLine(sizeof(Int32));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();


        // Unsigned Int32
        Console.WriteLine(nameof(UInt32));
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
        Console.WriteLine(sizeof(UInt32));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();


        // Double
        Console.WriteLine(nameof(Double));
        Console.WriteLine(Double.MinValue);
        Console.WriteLine(Double.MaxValue);
        Console.WriteLine(sizeof(Double));
        Console.WriteLine(new string('-', 10));
        Console.ReadKey();
    }

    private static void StructandClassRefandValue()
    {
        //Class ile örnek
        //Gamer oyuncu1 = new Gamer()
        //{
        //    NickName = "WShane",
        //    Stars = 5
        //};
        //Gamer oyuncu2 = oyuncu1;
        //oyuncu1.GetGamerInfos();
        //oyuncu2.GetGamerInfos();
        //Console.WriteLine(new string('-', 40));

        //oyuncu2.NickName = "DscWn";

        //oyuncu1.GetGamerInfos();
        //oyuncu2.GetGamerInfos();
        //Console.WriteLine(new string('-', 40));


        //AddStars(oyuncu2, 6);
        //Console.WriteLine(new string('-', 40));

        //oyuncu1.GetGamerInfos();
        //oyuncu2.GetGamerInfos();


        //Struct ile örnek
        //Game game1 = new Game()
        //{
        //    GameNick = "League of Legends",
        //    CurrentPlayer = 120000
        //};
        //Game game2 = game1;
        //game1.GetGameInfos();
        //game2.GetGameInfos();
        //Console.WriteLine(new string('-', 40));

        //game2.GameNick = "Valorant";
        //game1.GetGameInfos();
        //game2.GetGameInfos();
        //Console.WriteLine(new string('-', 40));

        //AddPlayer(game1, 45000);
        //Console.WriteLine(new string('-', 40));

        //game1.GetGameInfos();
        //game2.GetGameInfos();




        // Bunlar program.cs ye
        //public static void AddStars(Gamer oyuncu, int S)
        //{
        //    int AddStar = oyuncu.Stars + S;
        //    oyuncu.Stars = AddStar;
        //    oyuncu.GetGamerInfos();

        //}

        //public static void AddPlayer(Game game, int S)
        //{
        //    int AddPlayer = game.CurrentPlayer + S;
        //    game.CurrentPlayer = AddPlayer;
        //    game.GetGameInfos();

        //}



        //Bunlar ayrı class lar
        //    public class Gamer
        //{
        //    public string NickName { get; set; }
        //    public int Stars { get; set; }

        //    public void GetGamerInfos()
        //    {
        //        Console.WriteLine($"Kullanıcı Adı: {NickName} \nSahip Olunan Yıldız: {Stars}");
        //    }
        //}

        //public struct Game
        //{
        //    public string GameNick { get; set; }
        //    public int CurrentPlayer { get; set; }

        //    public void GetGameInfos()
        //    {
        //        Console.WriteLine($"Oyun Adı: {GameNick} \nMevcut Oyuncu: {CurrentPlayer}");
        //    }
        //}

        Console.ReadKey();
    }
    private static void ListeAgain()
    {
        var sehirler = new List<string>()
        {
            "Ankara",
            "İstanbul",
            "Samsun",
            "Trabzon",
            "Gümüşhane"
        };

        //foreach (var s in sehirler)
        //{
        //    Console.WriteLine(s);
        //}

        // lambda expression *araştır.

        sehirler.ForEach(s => Console.WriteLine(s));

        Console.WriteLine(new string('-', 50));

        var iller = sehirler;
        iller.ForEach(i => Console.WriteLine(i));
        Console.WriteLine(new string('-', 50));

        sehirler.Add("Sinop");
        sehirler.ForEach(s => Console.WriteLine(s));
        Console.WriteLine(new string('-', 50));

        iller.ForEach(i => Console.WriteLine(i));
        Console.WriteLine(new string('-', 50));

        iller.Remove("Ankara");
        iller.ForEach(i => Console.WriteLine(i));
        Console.WriteLine(new string('-', 50));

        sehirler.ForEach(s => Console.WriteLine(s));
    }

    private static void refDegisme()
    {
        int x = 10;
        int y = 20;
        Console.WriteLine("{0},{1}", x, y);
        Degistir(x, y);
        Console.WriteLine("{0},{1}", x, y);
        Degistir(ref x, ref y);
        Console.WriteLine("{0},{1}", x, y);
    }
    private static void Degistir(int a, int b)
    {
        int gecici = a;
        a = b;
        b = gecici;
        Console.WriteLine("{0},{1}", a, b);
    }
    private static void Degistir(ref int a, ref int b)
    {
        int gecici = a;
        a = b;
        b = gecici;
        Console.WriteLine("{0},{1}", a, b);
    }

    private static void Metodlar()
    {
        //double Odenecek = SatisYap();

        //double OdenecekMiktar = SatisYap(100);
        //var a = SatisYap();
        //var OdenecekMiktar2 = SatisYap(100, 0.2);
        //Console.WriteLine(OdenecekMiktar);
        //Console.WriteLine("{0,5:0##}", OdenecekMiktar2);

        /// <summary>
        /// Satış yapan fonksiyon
        /// </summary>
        /// <param name="miktar"> Alışveriş Tutarı</param>
        /// <returns>KDV Eklenmiş Ödeme Tutarı</returns>
        //static double SatisYap(double miktar = 0) // miktar = 0 burda default değer olarak kabul eder.
        //{
        //    return miktar * 1.18;
        //}
        /// < summary >
        /// İndirimli Satış Yapan Fonksiyon
        /// </ summary >
        /// < param name = "miktar" > Alışveriş Tutarı </ param >
        /// < param name = "indirim" > İndirim Oranı </ param >
        /// < returns > KDV dahil indirimli ödenecek miktar</ returns >
        //static double SatisYap(double miktar, double indirim)
        //{
        //    return (miktar * (1.0 - indirim)) * 1.18;
        //}

        //public static double SeriToplami(params double[] seri)
        //{
        //    /*main
        //    double toplam = SeriToplami(5.53, 1.68, 6.26);
        //    Console.WriteLine("{0,5:0.##}",toplam);
        //    Console.WriteLine(SeriToplami(5.53, 1.68, 6.26));
        //     */

        //    double toplam = 0;
        //    foreach (var s in seri)
        //        toplam += s;

        //    return toplam;
        //}

        //public static double KareAl(double A)
        //{
        //    /* bunlar main e 
        //    var x = KareAl(5);
        //    double y = KareAl(x);
        //    Console.WriteLine(x);
        //    Console.WriteLine(y); */


        //    double kare = A * A;
        //    return kare;
        //}

        //public static int Karsilastir(int A, int B)
        //{
        //    /* bunlar main e
        //    int buyuk = Karsilastir(13, 6);
        //    Console.WriteLine(buyuk);
        //    Console.WriteLine("Metod Bitti. "); */


        //    return 0;
        //    if (A >= B)
        //        return A;
        //    else
        //        return B;
        //    return A > B ? A : B; //BU ÇOK ÖNEMLİ. BUNU KULLAN.

        //    public static void Karsilastir()
        //    {
        //        Console.WriteLine("Karsilastir calisti. ");
        //    }

        //}

    }
    private static void Listeler()
    {
        // tanımlama
        var sayilar = new List<int>();
        int x = 22;
        int[] Seri = { 1, 2, 3 };
        // ekleme
        sayilar.Add(1);
        sayilar.Add(10);
        sayilar.Add(20);
        sayilar.Add(x);
        sayilar.AddRange(Seri);
        foreach (var item in Seri)
        {
            sayilar.Add(item); // bu kod ile addrange ile eklemek aynı işi görür.
        }

        sayilar.AddRange(new int[] { 21, 55, 43 });

        // Araya ekleme
        sayilar.Insert(3, 0);
        sayilar.InsertRange(4, new int[] { 94, 73, 99 });

        sayilar.RemoveAt(3);
        sayilar.RemoveAt(sayilar.IndexOf(99));

        // dolaşma
        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }
    }
    private static void ArrayListExamples()
    {
        //Tanımlama
        ArrayList arrayList = new ArrayList();
        //Ekleme
        arrayList.Add(10);
        arrayList.Add("Salim Can");
        arrayList.Add(true);
        arrayList.Add('s');
        //Dolaşma
        foreach (var item in arrayList)
            Console.WriteLine(item);

        //Tanımlama + Ekleme
        var arraysList = new ArrayList()
        {
            10,"Salimcan",true,DateTime.Now,'M'
        };
        int[] sayilar = { 1, 22, 5, 2222 };
        arraysList.AddRange(sayilar);
        foreach (var item in arraysList)
            Console.WriteLine(item);

        //Elemana erişme
        Console.WriteLine(arraysList[6]);

        // Elemana erişme - atama
        int x = (int)arraysList[0]; //unboxing - kutudan çıkartma
        Console.WriteLine(x + 10);
        Console.WriteLine();

        //eleman silme
        arraysList.Remove(10);
        arraysList.RemoveAt(0);
        arraysList.RemoveRange(3, 3);
        foreach (var item in arraysList)
            Console.WriteLine(item);
    }
    private static void Diziler()
    {
        // dizi tanımlama
        int[] aaa;
        // diziyi başlatma
        aaa = new int[4];
        // diziye eleman atama
        aaa[0] = 1;
        // dizi tanımlama + başlatma
        int[] bbb = new int[4];
        // dizi tanımlama && başlatma && atama
        int[] bbbb = new int[6] { 1, 2, 3, 4, 8, 12 };
        // daha kısa
        int[] numaralar = { 2, 5, 41, 332, 56, 15 };
        char[] harfler = { 'a', 'b', 'c', 'd' };

        for (int i = 0; i < numaralar.Length; i++)
        {
            Console.WriteLine($"Numaralar[{i}] = {numaralar[i]}");
        }
        for (int i = 0; i < harfler.Length; i++)
        {
            Console.WriteLine(harfler[i]);
        }


        // 
        Console.WriteLine("Dizi boyutunu giriniz: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[] sayilar = new int[boyut];
        var r = new Random();
        for (int i = 0; i < sayilar.Length; i++)
            sayilar[i] = r.Next(1, 10);

        foreach (int S in sayilar)
        {
            Console.WriteLine($"{S,5} {S * S,5}");
        }


        //
        double[,] matris = new double[,] { { 1, 2, 4 }, { 5, 7, 8 }, { 6, 11, 22 } };
        double toplam = 0;
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                if (i == j)
                    matris[i, j] = 1;
                if (matris[i, j] % 2 == 0)
                    matris[i, j] = 0;

                toplam += matris[i, j];

                Console.Write($"{matris[i, j],5}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Toplam = " + toplam);




    }
    private static void ForDonguleri()
    {

        /*
        // for tab tab
        for (int i = 0; i < 100; i+=5)
        {
            Console.WriteLine(i);
        }

        // forr tab tab
        for (int i = 100; i >= 0; i -= 5)
        {
            Console.WriteLine(i);
        }
        */
        //Console.WriteLine("i değeri için atama yapınız: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("i değeri için sınrlandırma ataması yapınız: ");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Gerekli işlemler yapılıyor...");
        //for (int i = a; i<b; i++) 
        //{
        //    //if (i%3 == 0)   /*Bu yapıda şu oluyor: eğer sayımız 3 ün katı ise alttaki kod çalışmadan direkt tekrar 
        //    //                 üste çıkar ve i nin değerini arttırır. böylece 3 ün katı olanları yazdırmak yerine bir üstüne geçer.*/
        //    //{
        //    //    continue;
        //    //}
        //    if (i==100)
        //    {
        //        break;
        //    }
        //    Console.WriteLine("{0,3}",i);
        //}

        /* iç içe for döngüleri, matrisler 
          
         Console.WriteLine("İstenen Değeri Giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            //for (int j = 0; j <= n; j++)
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" * ");
                //Console.Write( $" {i+1},{j+1} " );
            }
            Console.WriteLine();
        
         */

        // For ile örnek:
        /*
        Console.WriteLine("Döngü için Başlangıç Değeri Giriniz: ");
        int baslangic = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Döngü için Sınır Değeri Giriniz: ");
        int sinir = Convert.ToInt32(Console.ReadLine());

        for (int i = baslangic; i <= sinir; i++)
        {
            if (i%3 == 0)
            {
                Console.WriteLine("{0} değeri 3 e tam bölünür.",i);
            }
            else if (i%3 == 1)
            {
                Console.WriteLine("{0} değerinin 3 e bölümündan kalan 1 dir.",i);
            }
            else if (i%3 == 2)
            {
                Console.WriteLine("{0} değerinin 3 e bölümünden kalan 1 dir.",i);
            }
            else 
            {
                Console.WriteLine(i); 
            }
        }
        */
    }
    private static void DoWhile()
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Girilen sayı = {sayi} \nGerekli işlemler aşağıda yapılıyor...");

        int i = 2;
        do
        {
            Console.Write("{0,3}", i);
            Console.WriteLine(i);
            i += 2;
        } while (i <= sayi);
    }
    private static void While()
    {

        //int sayac = 10;
        //while (sayac > 0)
        //{
        //    //Console.Write(sayac+ " ");
        //    //Console.Write("{0,-4}", sayac);    /* Burada sayıları sola yaslayarak aralarında 3 boşluk, 4. ye de kendisi
        //    //                                     gelicek şekilde sıralarız. aradaki boşlukları - olduğu için sağa koyar.*/


        //    //Console.Write("{0,3}", sayac);       /* Burada sayıları sağa yaslayarak aralarında 3 boşluk, 4. ye de kendisi
        //    //                                     gelicek şekilde sıralarız. aradaki boşlukları - olduğu için Sola koyar.*/

        //    //Console.WriteLine(sayac);
        //    Console.WriteLine("{0,3} {1,-3}", sayac, sayac * sayac);
        //    sayac -= 1; /*  sayac ++ =>  sayac = sayac +1 
        //                 sayac += =>  sayac = sayac +1
        //                 Bu şekilde kolayca arttırabiliriz.
        //              */
        //}


        //int a = 1;
        //int i = 1;
        //int sayac = 0;
        //while (i < 10)
        //{
        //    sayac++;
        //    Console.WriteLine($"{sayac}. Çıktının değeri {a * 3}");
        //    a++;
        //}
        // breakpoint koyup incelerken DEBUG =>  WİNDOWS => LOCALS ile değişkenlerin değerlerini takip edebilirsin.
    }
    private static void SwitchCase()
    {
        //    enum Islemler => Burası main metoduna yazılmaz main den çıkıp tanımlıyoruz.
        //{
        //    Toplama = 1,
        //    Cikarma = 2,
        //    Carpma = 3,
        //    Bolme = 4
        //}

        //int A = 10, B = 20;
        ////Islemler secim = Islemler.Bolme;
        ////Islemler secim = (Islemler)1;
        //Islemler secim = (Islemler)(new Random().Next(1, 4));
        //switch (secim)
        //{
        //    case Islemler.Toplama:
        //        Console.WriteLine($"{A} +  {B} = {A + B}");
        //        break;
        //    case Islemler.Cikarma:
        //        Console.WriteLine($"{A} -  {B} = {A - B}");
        //        break;
        //    case Islemler.Carpma:
        //        Console.WriteLine($"{A} *  {B} = {A * B}");
        //        break;
        //    case Islemler.Bolme:
        //        Console.WriteLine($"{A} /  {B} = {A / B}");
        //        break;
        //    default:
        //        break;
        //}

        //var K = 'c';
        //switch (K)
        //{
        //    case 'a':
        //        break;
        //        Console.WriteLine("A");
        //    case 'b':
        //        break;
        //        Console.WriteLine("B");
        //    case 'c':
        //        Console.WriteLine("C");
        //        break;
        //}
    }
    private static void YazdirmaMetoduSecenekleri()
    {
        string ifade = " Merhaba programlama dünyası . ";
        Console.WriteLine(ifade);
        Console.WriteLine(ifade.Length);
        Console.WriteLine(ifade.ToUpper());
        Console.WriteLine(ifade.ToLower());
        Console.WriteLine(ifade.TrimStart());
        Console.WriteLine(ifade.TrimEnd());
        Console.WriteLine(ifade[0]);
        Console.WriteLine(ifade[1]);
        Console.WriteLine(ifade[ifade.Length - 1]);
    }
    private static void KacisIfadeleri()
    {
        string ifade = "\nBTK \nAkademi \nProgramlama \nOgreniyorum.";
        Console.WriteLine(ifade);
        ifade = "\tBTK \tAkademi \tProgramlama \tOgreniyorum.";
        Console.WriteLine(ifade);
        ifade = "\aBTK Akademi Programlama Ogreniyorum.";
        Console.WriteLine(ifade);
        ifade = "C:\\user\\Salimcan";   /* \ kaçış ifadesi olduğu için 
                                         * hatalı olmaması için \\ şeklinde yazılır. */
        Console.WriteLine(ifade);
        ifade = @"C:\user\Salimcan";    /* Veya başına @ yazılarakta kaçış ifadelerini 
                                         pas geçirebiliriz. \t \a \n hepsinde işe yarar.*/
        Console.WriteLine(ifade);
    }
    private static void BasicExamples()
    {
        int sayi = 3;
        Console.WriteLine(sayi);      // açıklama
        Console.WriteLine(sayi * 2);  /* açıklama */
        Console.WriteLine(sayi + 2);
        Console.WriteLine(sayi - 2);
    }
    private static void DegiskenOrnekleri()
    {
        // TYPES

        //int a = 1;
        //int b = 2 * a;
        //int sayi1;
        //double pi = 3.14;
        //char secim = 'A';
        //string isim = "Salim";
        //int a = 91;
        //var c = 20 * a;
        //var b = a + c;
        //int sayi = 5;

        string Name = "Salim";
        string Surname = "Sahin";
        int Age = 21;
        string University = "Samsun University";
        int Class = 4;

        Console.WriteLine("Hi, I'm " + Name + " " + Surname + " And I am "
            + Age + " and I'm studying as a " + Class + ". year student at " + University + ".");


        //Console.WriteLine(sayi);
        //Console.WriteLine(sayi*2);
        //Console.WriteLine(sayi+2);
        //Console.WriteLine(sayi-2);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(a*b);
        //Console.WriteLine(c+a);



        //string isim = "Ahmet";
        //Console.WriteLine("Merhaba " + isim + ".");
        //isim = "Salim";
        //Console.WriteLine("Merhaba Sayın " + isim + ".");

        Console.ReadKey();
    }

}