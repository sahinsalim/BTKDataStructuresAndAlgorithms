using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        //Git name and email changed.

        Console.ReadKey();
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
        double A = 20, B = 25;


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