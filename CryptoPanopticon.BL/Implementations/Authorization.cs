using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoPanopticon.BL.Interfaces;
using CryptoPanopticon.DA.Implementations.Models;

namespace CryptoPanopticon.BL.Implementations
{
    public class Authorization:IAuthorization {
        private readonly UserModel _userModel;
        public Authorization(UserModel userModel) {
            _userModel = userModel;
        }
        public bool Login(string login, string password) {
            return _userModel.GetAll().Find(user => user.Login.Equals(login) && user.Password.Equals(password)) != null;
        }
    }
}
