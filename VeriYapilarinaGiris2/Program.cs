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
