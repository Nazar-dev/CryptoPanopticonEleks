using CryptoPanopticon.DA.Interfaces;
using CryptoPanopticon.DA.Interfaces.Models;

namespace CryptoPanopticon.DA.Implementations.Models {
	public class UserModel: IUserModel {
		private IDataBase _dataBase;
		
		public UserModel(IDataBase dataBase) {
			_dataBase = dataBase;
		}
		public void AddUser(IUser user) {
			throw new System.NotImplementedException();
		}
		public IUser GetUser(int userId) {
			throw new System.NotImplementedException();
		}
		//TODO Realize method's
	}
}