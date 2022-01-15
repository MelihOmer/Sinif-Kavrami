using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Söz Dizimi
            // // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı(ParametreListesi);
            //     {
            //         //Metot Komutları
            //     }

            // }
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Melih Ömer";
            calisan1.Soyad="Kamar";
            calisan1.No=12345678;
            calisan1.Departman = "Software Developer";
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("**************************************************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No=87654321;
            calisan2.Departman ="İnsan Kaynakları";
            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışan Adı :{0}",Ad);
            System.Console.WriteLine("Çalışan Soy Adı :{0}",Soyad);
            System.Console.WriteLine("Çalışan Numarası :{0}",No);
            System.Console.WriteLine("Çalışan Departmanı :{0}",Departman);
        }
    }

}
