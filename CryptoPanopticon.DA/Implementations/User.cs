using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoPanopticon.DA.Interfaces;

namespace CryptoPanopticon.DA.Implementations
{
    class User:IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public IUserConfig UserConfig { get; set; }
       
    }
}
