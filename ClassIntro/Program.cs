using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emre";
            int yas = 21;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emre Erdem";
            kurs2.izlenmeOrani = 32;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Emre Erdem";
            kurs3.izlenmeOrani = 50;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + ":" + " " +item.Egitmen);
            }
            Console.ReadKey();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
        
    }
}
