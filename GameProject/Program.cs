using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { Id = 1, FirstName = "EMRE", BirthYear = 1998, TcNo = 12345 };

            GamerManage gamerManage = new GamerManage(new NewEdevletGamerValidationManager());
            Kampanyalar kampanya1 = new Kampanyalar() { KampanyaId = 1, KampanyaAdi = "YazKampaanyası", Indirim = 30 };
            SatisManager satisManager = new SatisManager();
            satisManager.satis(gamer, kampanya1);
            //gamerManage.Add(gamer);
            Console.ReadKey();
        }
    }
}
