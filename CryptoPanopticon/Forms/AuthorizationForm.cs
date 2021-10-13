using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoPanopticon.BL.Interfaces;

namespace CryptoPanopticon.Forms
{
    public partial class AuthorizationForm : Form
    {
        private IAuthorization authorization;

        public AuthorizationForm(IAuthorization authorization)
        {
            this.authorization = authorization;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool isSuccess = authorization.Login(textBox1.Text, textBox2.Text);
            switch (isSuccess)
            {
                case true:
                    ProccedToTheMainMenu();
                    break;
                case false:
                    ShowMessageAuthorizationUserDataWasNotFoundInDB();
                    break;
                    
            }

        }

        private void ShowMessageAuthorizationUserDataWasNotFoundInDB()
        {
           
            messageLabel.Text = "Login or password didnt match"; 
            messageLabel.Show();
        }


        private void ProccedToTheMainMenu()
        {
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Hide();
        }
    }
}
