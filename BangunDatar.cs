using System;

namespace Quiz09092019
{
    class BangunDatar
    {
        public void LuasPersegi()
        {
            int sisi;
            Console.Write("masukkan nilai sisi: ");
            sisi = Convert.ToInt32 (Console.ReadLine());

            int luas = sisi*sisi;

            Console.WriteLine("Luas persegi adalah " + luas);
        }

        public void LuasSegitiga()
        {
            int alas , tinggi;

            Console.Write("Masukan nilai alas: ");
            alas = Convert.ToInt32 (Console.ReadLine());
            
            Console.Write("Masukan nilai tinggi: ");
            tinggi = Convert.ToInt32 (Console.ReadLine());

            int luas = alas * tinggi / 2;

            Console.WriteLine("Luas segitiga adalah " + luas);
        }

        public void LuasLingkaran()
        {
           const double phi = 3.14;
           double luas;
           int r;

           Console.Write("Masukkan panjang jari-jari lingkaran:");
           r = Convert.ToInt32(Console.ReadLine());
           luas = phi * r * r;
           Console.WriteLine("Luas lingkaran adalah " + luas); 

        }

        public void BangunRuang()
        {
            BangunRuang obj = new BangunRuang();

            obj.VolumeBalok();

            obj.VolumeKubus();

            
        }






    }
}
