using System;
using System.Windows.Forms;
using CryptoPanopticon.BL.Implementations;
using CryptoPanopticon.DA.Implementations;
using CryptoPanopticon.DA.Implementations.Models;
using CryptoPanopticon.Forms;
using LiteDB;

namespace CryptoPanopticon {
	static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Application.Run(new AuthorizationForm(new Authorization(new UserModel(new DataBaseLiteDB(new LiteDatabase("String.db"))))));
			Application.Run(new RegistrationForm(new Registration(new UserModel(new DataBaseLiteDB(new LiteDatabase("String.db"))))));
		}
	}
}