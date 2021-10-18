using System.Collections.Generic;
using System.Linq;
using CryptoPanopticon.DA.Interfaces;
using CryptoPanopticon.DA.Interfaces.Models;
using LiteDB;

namespace CryptoPanopticon.DA.Implementations {
	public class DataBaseLiteDB : IDataBase {
		
		private readonly LiteDatabase _liteDb;
		private readonly ILiteCollection<IUser> _iUserTable;

		public DataBaseLiteDB(LiteDatabase liteDb) {
			this._liteDb = liteDb;
			this._iUserTable = _liteDb.GetCollection<IUser>(nameof(IUser));
		}
		public bool AddUser(IUser user) {
			_iUserTable.Insert(user);
			var findById = _iUserTable.FindById(user.Id);
			if (findById != null) {
				return true;
			}
			return false;
		}
		public IUser GetUserBy(int userId) {
			return _iUserTable.FindById(userId);
		}
		public List<IUser> GetAllUsers() {
			return _iUserTable.FindAll().ToList();
		}
	}
}