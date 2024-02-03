using System.Collections;

namespace VeriYapilarinaGiris2
{
    public class VeriYapilariExamples
    {


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
