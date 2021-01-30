using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SatisManager : ISatisService
    {
        public void satis(Gamer gamer, Kampanyalar kampanyalar)
        {
            Console.WriteLine(gamer.FirstName +" isimli müşterimize" +" " +kampanyalar.KampanyaAdi + " uygulanmıştır." );
        }
    }
}
