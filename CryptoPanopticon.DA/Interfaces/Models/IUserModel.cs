using System.Collections.Generic;
using System.Linq;
using CryptoPanopticon.DA.Implementations;

namespace CryptoPanopticon.DA.Interfaces.Models {
	public interface IUserModel {
		bool AddUser(IUser user); //Add new User
		IUser GetUser(int userId); //Get User by iD
		List<IUser> GetAll();
	}
}