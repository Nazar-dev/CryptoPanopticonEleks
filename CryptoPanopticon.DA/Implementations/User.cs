using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoPanopticon.DA.Interfaces;
using CryptoPanopticon.DA.Interfaces.Models;

namespace CryptoPanopticon.DA.Implementations
{
    public class User:IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public IUserConfig UserConfig { get; set; }
    }
}
