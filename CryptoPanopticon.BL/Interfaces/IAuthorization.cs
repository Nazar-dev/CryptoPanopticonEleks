namespace CryptoPanopticon.BL.Interfaces {
	public interface IAuthorization {
		bool Login(string login, string password); // should return True if user Exist else false

	}
}