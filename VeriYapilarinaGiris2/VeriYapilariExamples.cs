using System.Collections;

namespace VeriYapilarinaGiris2
{
    public class VeriYapilariExamples
    {

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

        private static void SortedListApp()
        {
            // SortedList App

            var kitapIcerigi = new SortedList()
            {
                {1, "Önsöz" },
                {3, "Değişkenler" },
                {5, "Operatörler" },
                {13, "Döngüler" },
                {42, "İlişkisel Operatörler" }
            };

            Console.WriteLine("İçindekiler: \n ");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                string formattedKey = ((int)item.Key).ToString("D2");
                Console.WriteLine($"{formattedKey,-2}  => {item.Value,-27}");

            }
        }

        private static void SortedListTemel()
        {
            // Sortedlist - Temel

            // Tanımlama 
            var list = new SortedList()
            {
                {1, "Bir" },
                {2, "İki" },
                {6, "Altı" }
            };
            list.Add(4, "Dört");

            // Dolaşma
            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,-1} - {item.Value}");


            Console.WriteLine("Listedeki eleman sayısı = {0} ", list.Count);
            Console.WriteLine("Listenin kapasitesi = " + list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin kapasitesi = {0} ", list.Capacity);

            // Erişme
            //Key
            Console.WriteLine(list[4]);
            //Index
            Console.WriteLine(list.GetByIndex(list.Count - 1));
            // Get = > Key
            Console.WriteLine(list.GetKey(0));

            // Anahtar listesi
            Console.WriteLine("\nKeys:");
            var anahtarlar = list.Keys;
            foreach (var item in anahtarlar)
                Console.WriteLine(item);

            // Değer listesi
            Console.WriteLine("\nValues:");
            var degerler = list.Values;
            foreach (var item in degerler)
                Console.WriteLine(item);

            // Güncelleme
            //Değiştirme
            list[2] = "SS";
            Console.WriteLine(new string('-', 10));
            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,-1} - {item.Value}");

            //Ekleme
            list.Add(9, "Dokuz");
            Console.WriteLine(new string('-', 10));
            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,-1} - {item.Value}");

            //Çıkarma
            list.Remove(4);
            Console.WriteLine(new string('-', 10));
            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,-1} - {item.Value}");

            //Key kontrol ederek Değiştirme
            Console.WriteLine(new string('-', 10));
            var degistirilecekValueKey = 2;
            if (list.ContainsKey(degistirilecekValueKey))
            {
                list[degistirilecekValueKey] = "Değiştirilen Değer";
            }
            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,-1} - {item.Value}");

            //Value kontrol ederek Değiştirme
            Console.WriteLine(new string('-', 10));
            var degistirilecekValueValue = "Dokuz";
            if (list.ContainsValue(degistirilecekValueValue))
            {
                var arananIndex = list.IndexOfValue(degistirilecekValueValue);
                var arananIndexKeyi = list.GetKey(arananIndex);
                list[arananIndexKeyi] = "AAA";

            }
            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,-1} - {item.Value}");

            ////Value kontrol ederek Değiştirme kod sadeleştirme
            //if (list.ContainsValue(degistirilecekValueValue))
            //    list[list.GetKey(list.IndexOfValue(degistirilecekValueValue))] = "AAA";
        }

        private static void HashtableApp()
        {
            // Hashtable Uygulaması

            Console.WriteLine("Başlık giriniz: ");
            string baslik = Console.ReadLine();

            // kucultme
            baslik = baslik.ToLower();

            // Hashtable
            var karakterseti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ğ','g'},
                {'ü','u'},
                {'ş','s'},
                {' ','-'},
                {'\'','-'},
                {'.','-'},
                // daha önce eklenen bir key i tekrar eklersek hata verir. keyler eşsiz olmalı

            };

            foreach (DictionaryEntry item in karakterseti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            Console.WriteLine(baslik);
        }

        private static void HashTableExamples()
        {
            // HASHTABLE
            // Tanımlama
            var sehirler = new Hashtable();

            // Ekleme
            sehirler.Add(1, "Adana");
            sehirler.Add(61, "Trabzon");
            sehirler.Add(55, "Samsun");
            sehirler.Add(6, "Ankara");
            sehirler.Add(29, "Gümüşhane");

            // Dolaşma
            Console.WriteLine("Keys & Values");
            foreach (DictionaryEntry item in sehirler)
                Console.WriteLine($"{item.Key,-2} : {item.Value,4}");

            // Anahtar alma
            Console.WriteLine("\nKeys:");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
                Console.WriteLine(item);

            // Değer alma
            Console.WriteLine("\nValues:");
            var degerler = sehirler.Values;
            foreach (var item in degerler)
                Console.WriteLine(item);

            // Elemana erişme
            Console.WriteLine("\nElemana Erişme");
            Console.WriteLine(sehirler[55]);

            // Eleman silme
            Console.WriteLine("\nEleman Silme");
            sehirler.Remove(6);

            foreach (DictionaryEntry item in sehirler)
                Console.WriteLine($"{item.Key,-2} : {item.Value,4}");
        }

        public static void ArrayDiziExamples()
        {
            // Array | Dizi
            int[] sayilar = { 5, 3, 2, 7, 10, 18, 42, 36 };
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            var arr = new ArrayList(sayilar);

            // tek tek manuel ekleme
            //numbers.SetValue(2, 0);
            //numbers.SetValue(4, 1);
            //numbers.SetValue(6, 2);
            //numbers.SetValue(9, 3);
            //numbers.SetValue(5, 4);

            // for ile sayılardakini buraya ekleme
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    numbers.SetValue(sayilar[i],i);
            //}

            // copyto metodu ile sayiları kopyala (hangi diziye kopyalanacağı, kaçıncı indexten itibaren kopyalanacağı);
            //sayilar.CopyTo(numbers, 0);


            sayilar.CopyTo(numbers, 0);
            Array.Sort(sayilar);
            Array.Sort(numbers);
            Array.Clear(sayilar, 1, 2);
            arr.Sort();


            var x = Array.IndexOf(sayilar, 42);
            Console.WriteLine(x);


            // dolaşma
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = {sayilar[i],-3} &  " +
                    $"numbers[{i}] = {numbers.GetValue(i),-3} &  " +
                    $"arr[{i}] = {arr[i],-3}");
            }

            /*for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //Console.WriteLine(new string('-',20));

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers.GetValue(i));
            }
            */
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
