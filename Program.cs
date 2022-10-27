using System;

namespace algoritma
{
    class Program
    {
        static void Main(String[] args)
        {
            HomeWork2();
        }
        static void HomeWork1()
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            int sayac = 0;

            Console.Write("Kaç Adet sayı girmek istersin: ");
            var n = Convert.ToInt32(Console.ReadLine());

            {
                List<int> ciftSayilar = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    sayac++;
                    Console.Write(sayac + ". sayıyı giriniz");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        ciftSayilar.Add(sayi);
                    }
                }

                foreach (var sayi in ciftSayilar)
                {
                    Console.Write(sayi + " ");
                }

            }
            Console.Read();
        }

        static void HomeWork2()
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Please enter 2 positive numbers");
            Console.Write("First number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You need to enter {0} positive numbers.", n);

            int[] numberarray = new int[n];

            for (int i = 1; i < n + 1; i++)
            {

                Console.Write("Number {0}: ", i);
                numberarray[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var number in numberarray)
            {
                if (number == m)
                {
                    Console.WriteLine(number);
                }
                else if (number % m == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void Homework3()
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Please enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("You need to enter 5 words.");

            string[] wordarray = new string[n];

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write("Word 1: ");
                wordarray[i - 1] = Console.ReadLine();
            }

            Array.Reverse(wordarray);

            foreach (var word in wordarray)
            {
                Console.WriteLine(word);
            }
        }
        static void Homework4()
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            
            Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();

            int numberofcharacters = sentence.Count();

            string letters = "abcçdefgğhıijklmnoöprsştuüvyzxwq";

            int numberofletters = 0;
            for (int i = 0; i < numberofcharacters; i++)
            {
                if (letters.Contains(sentence[i]))
                {
                    numberofletters++;
                }
            }

            Console.WriteLine("Number of letters the sentence you entered: " + numberofletters);


            string[] words = sentence.Split(' ');

            Console.WriteLine("Number of words the sentence you entered: " + words.Length);
        }
    }
}



}
