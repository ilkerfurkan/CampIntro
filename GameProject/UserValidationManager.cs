using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "İLKER FURKAN" && gamer.LastName == "ŞAHİN" && gamer.IdentityNumber == 12345678910)
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
