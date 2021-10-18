namespace CryptoPanopticon.DA.Interfaces.Models {
	public interface IUser {
		// User fields
		public int Id { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public IUserConfig UserConfig { get; set; }
	}
}