namespace CryptoPanopticon.DA.Interfaces.Models {
	public interface IUserModel {
		void AddUser(IUser user); //Add new User
		IUser GetUser(int userId); //Get User by iD
		
	}
}