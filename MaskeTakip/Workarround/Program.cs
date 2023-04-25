using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workarround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();

            //Vatandas vatandas1 = new Vatandas();

            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();


            int sonuc = Topla(6,58);

            //Diziler / Arrays

            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";
            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //ogrenciler[3] = "İlker"; eleman sayısını ge.tiğimiz için hata verir.
            
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            //Person person1 = new Person();
            //person1.FirstName = "Engin";

            //Person person2 = new Person();
            //person2.FirstName = "Murat";

            string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir"};
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Fatih";
            person1.LastName = "Kelebek";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdenty = 123;

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Aydın", "Sivas", "Muş" };
            yeniSehirler1.Add("Adana");
            foreach (var sehir in yeniSehirler1)
            {

            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc.ToString());
            return sonuc;
        }

    //    private static void Degiskenler()
    //    {
    //        string mesaj = "Merhaba";
    //        double tutar = 100000;
    //        int sayi = 100;
    //        bool girisYapmisMi = false;

    //        string ad = "Engin";
    //        string soyad = "Demiroğ";
    //        int dogumYili = 1985;
    //        long tcNo = 12345678910;


    //        Console.WriteLine(mesaj);
    //        Console.WriteLine(tutar * 1.18);
    //    }
    //}
    //// public ile yaptığımızda kelimelerin ilk harfi büüyk olur.Buna pascal casing denir.
    //public class Vatandas
    //{
    //    public String Ad { get; set; } //Değişkenleri yönettiğimiz kısım.
    //    public String Soyad { get; set; }
    //    public int DogumYili { get; set; }
    //    public long TcNo { get; set; }
    }
}

