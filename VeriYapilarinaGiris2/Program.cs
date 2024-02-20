using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;


namespace VeriYapilarinaGiris2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        private static void HashSetApp()
        {
            // HashSet

            // Tanımlama
            var sesliHarf = new HashSet<char>()
            {
                'e','ı','i','u','ü','o','ö','b'
            };
            sesliHarf.Add('a');

            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);
            //Console.WriteLine();
            //foreach (char k in sesliHarf)
            //{
            //    Console.Write($"{k,5}");
            //}
            //Console.WriteLine("Eleman Sayısı: {0}",sesliHarf.Count);
            //Console.WriteLine();

            var alfabe = new List<char>();
            for (int i = 97; i < 122; i++)
            {
                alfabe.Add((char)i);
            }
            alfabe.ForEach(x => { Console.WriteLine(" " + x + "  Listeye eklendi"); });
            //foreach (var h in alfabe)
            //{
            //    Console.WriteLine($"{h,3} Alfabeye eklendi.");
            //}
            KoleksiyonYazdir(alfabe);

            // Türkçe de kullanılan sesli harfler
            sesliHarf.ExceptWith(alfabe);
            KoleksiyonYazdir(sesliHarf);

            sesliHarf.UnionWith(alfabe);
            KoleksiyonYazdir(sesliHarf);

            sesliHarf.IntersectWith(alfabe);
            KoleksiyonYazdir(sesliHarf);
        }

        static void KoleksiyonYazdir(IEnumerable koleksiyon)
        {
            Console.WriteLine();
            foreach (char k in koleksiyon)
            {
                Console.Write($"{k,5}");
            }
            //Console.WriteLine("\nEleman Sayısı: {0}", koleksiyon.Count);
            Console.WriteLine();
        }

        private static void SortedSetApp2()
        {
            // SortedSet Küme İşlemi

            var A = new SortedSet<int>() { 1, 2, 3, 4 };
            //var A = new SortedSet<int>(RastgeleSayiUret(100));
            var B = new SortedSet<int>() { 1, 2, 5, 6 };
            //var B = new SortedSet<int>(RastgeleSayiUret(100));


            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A Kümesi: ");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine();
            Console.WriteLine("B Kümesi: ");
            foreach (var s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            // Union

            // A.UnionWith(B) => A ile B nin birleşimi
            // A.IntersectWith(B); => A ile B nin Kesişimi
            // A.ExceptWith(B); => Sadece A da bulunanlar
            // A.SymmetricExceptWith(B); => Sadece A da bulunanlar hariç diğerleri
            //A.IsSubsetOf(B); => A, B nin alt kümesi mi ?
            Console.WriteLine();
            Console.WriteLine("A ve B kümesinin birleşimi: ");
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();
            //Console.WriteLine("Birleşim kümesinin eleman sayısı = {0}",A.Count);
            //Console.WriteLine("Kesişim kümesinin eleman sayısı = {0}", A.Count);
            //Console.WriteLine("Sadece A kümesinin eleman sayısı = {0}", A.Count);
            //Console.WriteLine("Sadece A kümesinin elemanları hariç toplam eleman sayısı = {0}", A.Count);




            //static List<int> RastgeleSayiUret(int n)
            //{
            //    var list = new List<int>();
            //    var r = new Random();
            //    for (int i = 0; i < n; i++)
            //        list.Add(r.Next(0, 1000));
            //    return list;
            //}

        }

        private static void SortedSetUygulama()
        {

            // SortedSet

            var sayilar = new List<int>();
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 10));
                Console.WriteLine("{0} Listeye eklendi.", sayilar[i]);
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanları bulmak.
            var benzersizler = new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayiların listesi: ");
            foreach (var item in benzersizler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(benzersizler.Count);
        }

        private static void SortedSetBasics()
        {
            // SortedSet

            // Tanımlama
            var list = new SortedSet<string>();

            // Ekleme
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız.");
            }

            Console.WriteLine("{0}", list.Add("Ahmet") == true ?
              "Ahmet Eklendi." : "Ekleme Başarısız.");

            // Burada eklenmediği için her elemanın benzersiz olması gerektiğini anladık.
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız.");
            }

            list.Add("Salim");
            list.Add("Rahim");
            list.Add("Ufuk");
            list.Add("Yunus");

            list.Remove("Ufuk");
            //list.RemoveWhere(deger => deger.Contains("A"));
            list.RemoveWhere(deger => deger.StartsWith("M"));

            Console.WriteLine("\nİsimler Listesi: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Eleman sayısı :{0,3}", list.Count);
        }

        private static void SortedDictionaryExamples()
        {
            var bookIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTML", new List<int>(){8,10,12} },
                {"CSS", new List<int>(){78,170,212} },
                {"JQuery", new List<int>(){77,155,130} },
                {"SQL", new List<int>(){80,100} },

            };
            bookIndex.Add("FTP", new List<int>() { 3, 5, 7 });
            bookIndex.Add("ASP.NET", new List<int>() { 50, 60 });

            foreach (var item in bookIndex)
            {
                Console.WriteLine(item.Key);
                item.Value.ForEach(x => Console.WriteLine("\t>" + x));

                //Console.WriteLine(item.Value);

                //foreach (int s in item.Value)
                //{
                //    Console.WriteLine($" > {s} pp");
                //}


            }
        }

        private static void DictionaryWithPersonel()
        {
            // Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Arif", "Kalaycı",40000) },
                {120, new Personel("Rayim","Işık",100000) }
            };
            personelListesi.Add(100, new Personel("Salim", "Şahin", 30000));
            foreach (var item in personelListesi)
            {
                Console.WriteLine(item);
            }
        }

        private static void DictionaryBasics()
        {
            // Dictionary
            // Tanımlama
            var telefonkodlari = new Dictionary<int, string>()
            {
                {661, "Trabzon" }
            };

            // Ekleme
            telefonkodlari.Add(322, "Adana");
            telefonkodlari.Add(212, "Samsun");
            telefonkodlari.Add(216, "İstanbul");
            telefonkodlari.Add(222, "Samsun");

            // Erişim
            telefonkodlari[222] = "İzmir";

            // ContainsKey
            if (!telefonkodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'Nın kod bilgisi tanımlı değil");
                telefonkodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");
            }


            // ContainsValue
            if (!telefonkodlari.ContainsValue("Erzincan"))
            {
                Console.WriteLine("\aErzincan için kod bilgisi tanımlı değil.");
                telefonkodlari.Add(422, "Erzincan");
                Console.WriteLine("Yeni kod eklendi.");
            }


            foreach (var item in telefonkodlari)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinkedListExamples()
        {
            // LinkedList<T> Temelleri
            // Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Samsun");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");

            sehirler.AddAfter(sehirler.Find("Samsun"), "Sinop");
            sehirler.AddBefore(sehirler.First.Next.Next.Next, "Kocaeli");
            sehirler.AddBefore(sehirler.Last.Previous, "Zonguldak");

            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("\nGidiş Güzergahı\n ");
            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine("\nDönüş Güzergahı\n ");
            var elemans = sehirler.Last;
            while (elemans != null)
            {
                Console.WriteLine(elemans.Value);
                elemans = elemans.Previous;
            }
        }

        private static void QUEUEExamples1()
        {
            // QUEUE EXAMPLES
            var voiceLetter = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim;
            var queue = new Queue<char>();

            foreach (var k in voiceLetter)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} Kuyruğa eklensin mi ? [e/h] ");
                secim = Console.ReadKey();
                Console.WriteLine();

                if (secim.Key == ConsoleKey.E)
                {
                    queue.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} Kuyruğa eklendi. ");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {queue.Count} ");
                    Console.WriteLine();
                }

            }
            Console.WriteLine($"Kuyruktaki eleman sayısı: {queue.Count} ");


            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanların kaldırılması işlemi için Esc tuşuna basınız.");
            secim = Console.ReadKey();
            if (secim.Key == ConsoleKey.Escape)
            {
                while (queue.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{queue.Dequeue()} Kuyruktan çıkarıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {queue.Count} ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine($"\nKuyruktan eleman çıkarma işlemi tamamlandı" +
                $"\nKuyruktaki eleman sayısı: {queue.Count} ");
        }

        private static void QUEUEBasics()
        {
            // QUEUE

            // Tanımlama
            var charQueue = new Queue<char>();

            // Ekleme
            charQueue.Enqueue('S');
            charQueue.Enqueue('M');
            charQueue.Enqueue('A');
            Console.WriteLine($"Kuyruğun başındaki eleman = {charQueue.Peek()}");
            Console.WriteLine($"Kuyruğun eleman sayısı = {charQueue.Count}");

            // Ek bilgi
            //var dizi = charQueue.ToArray(); // Bu şekilde diziye atama işlemi oldu.
            //Console.WriteLine(dizi);


            // Çıkarma
            Console.WriteLine($"{charQueue.Dequeue()} Kuyruktan çıkarıldı.");
            Console.WriteLine($"Kuyruğun eleman sayısı = {charQueue.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman = {charQueue.Peek()}");
        }

        private static void StackExamples2()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var intStack = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                intStack.Push(k);
                sayi /= 10;
            }

            int i = 0;
            int n = intStack.Count - 1;
            foreach (var s in intStack)
            {
                Console.WriteLine($"{s} * {Math.Pow(10, n - i)} = {s * Math.Pow(10, n - i)}");
                i++;

            }
        }

        private static void StackExamples1()
        {
            var charStack = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                charStack.Push((char)i);
                Console.WriteLine($"{charStack.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayisi = {charStack.Count}");
            }
            // Ek bilgi
            var dizi = charStack.ToArray(); // DİZİNİN TÜRÜ BURDA CHAR LİSTESİ OLARAK GELİYOR.

            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız");
            Console.ReadKey();



            while (charStack.Count > 0)
            {
                Console.WriteLine($"{charStack.Pop()} yığından çıkarktıldı.");
                Console.WriteLine($"Yığındaki eleman sayisi = {charStack.Count}");

            }
        }

        private static void StackBasics()
        {
            // Stack<T>  tanımlama
            var karakterYigini = new Stack<char>();

            // Ekleme
            karakterYigini.Push('a');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('c');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('b');
            Console.WriteLine(karakterYigini.Peek());

            // Çıkarma
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
        }
    }
}
