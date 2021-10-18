using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoPanopticon.BL.Interfaces;

namespace CryptoPanopticon.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly IRegistration _registration;
        public RegistrationForm(IRegistration registration)
        {
            _registration = registration;
            InitializeComponent();
        }

        private bool IsFieldsFilled()
        {
            return userLoginField.Text.Length != 0 || passwordField.Text.Length != 0 || userNameField.Text.Length != 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsFieldsFilled())
            {
                ShowMessageSomeFieldsEmpty();
                return;
            }

            if (_registration.IsUserExistBy(userLoginField.Text, out _))
            {
                ShowMessageIsUserExist();
                return;
            }
            bool isRegistrationSucces = _registration.Register(userNameField.Text, userLoginField.Text, passwordField.Text, out _);
            if (!isRegistrationSucces)
            {
                ShowMessageNotRecognitionExeption();
                return;
            }
            MessageBox.Show("SUCCESS");
            //TODO swap this form to Auth form 
            //TODO create data correction checker (Patern)
        }

        private void ShowMessageNotRecognitionExeption()
        {
            messageLabel.Text =  @"Something went wrong try again with another data";
            messageLabel.Show();
        }

        private void ShowMessageIsUserExist()
        {
            messageLabel.Text = @"This login is already taken";
            messageLabel.Show();
        }
        private void ShowMessageSomeFieldsEmpty()
        {
            messageLabel.Text = @"You did not filled some fields.";
            messageLabel.Show();
        }

        private void userLoginField_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Hide();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Hide();
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Hide();
        }
    }
}
