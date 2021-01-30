using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class EdevletValidationManager : IGamerValidationService
    {
        public bool Valid(Gamer gamer)
        {
            if(gamer.Id==1 && gamer.FirstName=="EMRE" && gamer.BirthYear==1999 && gamer.TcNo == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
