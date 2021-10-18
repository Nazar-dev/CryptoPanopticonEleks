using System.Collections.Generic;
using CryptoPanopticon.DA.Interfaces;
using CryptoPanopticon.DA.Interfaces.Models;

namespace CryptoPanopticon.DA.Implementations.Models {
	public class UserModel: IUserModel {
		private IDataBase _dataBase;
		
		public UserModel(IDataBase dataBase) {
			_dataBase = dataBase;
		}

		public bool AddUser(IUser user) {
			return _dataBase.AddUser(user);
		}
		public IUser GetUser(int userId) {
			return _dataBase.GetUserBy(userId);
		}
		public List<IUser> GetAll() {
			return _dataBase.GetAllUsers();
		}
	}
}