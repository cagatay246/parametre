using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Sarkisoz();

            static void Sarkisoz()
            {
                Console.WriteLine("DAS HERZ İN FLAMMEN");
           }


            //RASTGELE SAYI ÜRETME VE BÖLME
            static int rastgel()
           {
                Random random = new Random();  
                int sayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üret
               Console.WriteLine($"Üretilen rastgele sayı: {sayi}");
                return sayi % 2; 
           }

            static void Main(string[] args)
            {
                
               int kalan = rastgel();  
                Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {kalan}");
          }




            // Parametre olarak iki sayıyı alıp çarpımlarını döndüren metot
            static int CarpmaIslemi(int sayi1, int sayi2)
            {
                return sayi1 * sayi2; // Sayıların çarpımını döndür
            }
            
                // Kullanıcıdan iki sayı alınır
                Console.Write("Birinci sayıyı girin: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                // CarpmaIslemi metodu çağrılır ve sonucu ekrana yazdırılır
                int sonuc = CarpmaIslemi(sayi1, sayi2);
                Console.WriteLine($"Girilen sayıların çarpımı: {sonuc}");

            // Parametre olarak isim ve soyisim alıp ekrana hoş geldiniz mesajı yazdıran metot
            static void HosgeldinizMesaji(string isim, string soyisim)
            {
                Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}!");
            }

                // Kullanıcıdan isim ve soyisim alınır
                Console.Write("İsminizi girin: ");
                string isim = Console.ReadLine();

                Console.Write("Soyisminizi girin: ");
                string soyisim = Console.ReadLine();

                HosgeldinizMesaji(isim, soyisim);
         
       














    }
    }
}