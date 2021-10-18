using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoPanopticon.DA.Interfaces;
using CryptoPanopticon.DA.Interfaces.Models;

namespace CryptoPanopticon.BL.Interfaces
{
    public interface IRegistration
    {
        bool Register(string userName,string login, string password,out IUser user);//Should return new User
        bool IsUserExistBy(string login,out IUser user);
    }
}
