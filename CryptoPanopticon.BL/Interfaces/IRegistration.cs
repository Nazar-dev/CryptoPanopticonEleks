using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoPanopticon.DA.Interfaces;

namespace CryptoPanopticon.BL.Interfaces
{
    public interface IRegistration
    {
        bool Registration(string userName,string login, string password,out IUser user);//TODO must return new User
        bool IsUserExistBy(string login,out IUser user);//TODO should check if user exist by his login
    }
}
