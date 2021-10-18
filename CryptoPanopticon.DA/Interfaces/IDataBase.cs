using System.Collections.Generic;
using CryptoPanopticon.DA.Interfaces.Models;

namespace CryptoPanopticon.DA.Interfaces
{
    public interface IDataBase
    {
        bool AddUser(IUser user);
        IUser GetUserBy(int userId);
        List<IUser> GetAllUsers();
    }
}