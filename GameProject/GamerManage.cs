using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManage : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManage(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_gamerValidationService.Valid(gamer)==true)
            {
                Console.WriteLine("Kayıt eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
