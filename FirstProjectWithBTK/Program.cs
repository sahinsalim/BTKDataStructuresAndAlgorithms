using System.Collections;

internal class Program
{

    
    private static void Main(string[] args)
    {


        Console.ReadKey();
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
        ////Tanımlama
        //ArrayList arrayList = new ArrayList();
        ////Ekleme
        //arrayList.Add(10);
        //arrayList.Add("Salim Can");
        //arrayList.Add(true);
        //arrayList.Add('s');
        ////Dolaşma
        //foreach (var item in arrayList)
        //    Console.WriteLine(item);

        // Tanımlama + Ekleme
        var arraysList = new ArrayList()
        {
            10,"Salimcan",true,DateTime.Now,'M'
        };
        int[] sayilar = { 1, 22, 5, 2222 };
        arraysList.AddRange(sayilar);
        //foreach (var item in arraysList)
        //    Console.WriteLine(item);

        ////Elemana erişme
        //Console.WriteLine(arraysList[6]);

        //// Elemana erişme - atama
        //int x = (int)arraysList[0]; //unboxing - kutudan çıkartma
        //Console.WriteLine(x+10);
        //Console.WriteLine();

        // eleman silme
        //arraysList.Remove(10);
        //arraysList.RemoveAt(0);
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
        char[] harfler = {'a', 'b', 'c', 'd'};

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

    private static void KarakterYorumlama()
    {
        var k = (char)Console.Read();
        if (char.IsDigit(k))
        {
            Console.WriteLine("Rakamdır!");
        }
        else if (char.IsLower(k))
        {
            Console.WriteLine("Küçük Karakter.");
        }
        else if (char.IsUpper(k))
        {
            Console.WriteLine("Büyük Karakter.");
        }
        else
        {
            Console.WriteLine("Bilinmeyen Karakter!");
        }
    }

    private static void MutlakDegerHesaplama()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine($"|{n}| = {n * -1} ");
        }
        else
        {
            Console.WriteLine($"|{n}| = {n} ");
        }
    }

    private static void TekmiCiftmi()
    {
        // Tek mi Çift mi?
        Console.WriteLine("Bir Sayı Giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} tek bir sayıdır.");
        }
    }

    private static void Operatorler()
    {
        //double A = 20, B = 25;


        //Aritmetik Operatörler
        //Console.WriteLine(A + B);
        //Console.WriteLine(A - B);
        //Console.WriteLine(A * B);
        //Console.WriteLine(A / B);
        //Console.WriteLine(A % B);

        //İlişkisel Operatörler
        //Console.WriteLine(A > B);
        //Console.WriteLine(A < B);
        //Console.WriteLine(A >= B);
        //Console.WriteLine(A <= B);
        //Console.WriteLine(A == B);
        //Console.WriteLine(A != B);

        // Koşul Operatörleri ( && ve, || veya, ! not)
        //Console.WriteLine(A > B && A < 5);
        //Console.WriteLine(!(A > B && A < 5));
        //Console.WriteLine(A < B || B > 5);

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

    private static void OrtuluDegisken()
    {
        // örtülü değişken (var)
        var ifade = Console.ReadKey();
        Console.WriteLine(ifade.Key);
        Console.WriteLine(ifade.KeyChar);
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