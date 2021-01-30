using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KampanyaManager : IKampanyaService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
