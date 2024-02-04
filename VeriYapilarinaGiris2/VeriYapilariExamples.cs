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


    }
}
