using System;

namespace w3_h2_ref_out_kavramlari
{
    class Program
    {
        /*
        ref: Referans anlamına gelmektedir.Değer tipli bir değişken ile işlem yaparken referans bilgisini 
        değiştirmek istediğimiz zaman bu ifadeyi kullanırız.
        ref ifadesi kullanılacak olan değer tipli değişkenin daha önceden tanımlanmış ve bir değer ataması 
        yapılmış olması gerekmektedir.

        out: Deper tipli bir değişken ile işlem yaparken referans bilgisini değiştirmek istedimiz zaman bu 
        ifadeyi kullanırız. (ref ile benzer özellik)
        Fakat ref anahtar kelimesinden farklı olarak out ifadesi kullanılacak olan değer tipli değişkenin 
        daha önceden tanımlanmış olması gerekirken bir değer ataması yapılmış olması gerekmemektedir.
        */
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            int number3;

            Console.WriteLine(Add(ref number1, number2));
            // Ekran çıktısı: 50

            Console.WriteLine(Add(number1, out number3));
            // Ekran çıktısı: 130

        }

        static int Add(ref int number1, int number2)
        {
            number1 = 30;
            int result = number1 + number2;
            return result;
        }

        static int Add(int number1, out int number2)
        {
            number2 = 100;
            int result = number1 + number2;
            return result;
        }
    }
}
