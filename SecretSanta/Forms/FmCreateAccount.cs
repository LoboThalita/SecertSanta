using SecretSanta.Domain.Entities;
using SecretSanta.Domain.Interfaces;
using System.Text.RegularExpressions;

namespace SecretSanta.Forms
{
    public partial class FmCreateAccount : Form
    {
        private readonly ICreateAccountService _createAccountService;
        public FmCreateAccount(ICreateAccountService createAccountService)
        {
            InitializeComponent();
            _createAccountService = createAccountService;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidFields())
            {
                var client = new Client()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                var result = _createAccountService.CreateNewAccount(client);

                if(result) MessageBox.Show("Conta Criada com sucesso");

                var form = this;
                form.Close();
            }
        }

        private bool ValidFields()
        {
            bool allValid = true;

            allValid &= ValidateField(txtName, TxtNameError);
            allValid &= ValidateField(txtEmail, TxtEmailError);
            allValid &= ValidateField(txtPassword, TxtPasswordError);
            allValid &= ValidateField(txtPasswordConfirm, txtCornfirmPasswordError);

            if (!ValidateEmail(txtEmail.Text))
            {
                TxtEmailError.Text = "E-mail inválido";
                TxtEmailError.Visible = true;
                allValid = false;
            }
            else
            {
                TxtEmailError.Text = "";
                TxtEmailError.Visible = false;
            }

            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                txtCornfirmPasswordError.Text = "Senhas não conferem";
                txtErrorMessage.Visible = true;
                allValid = false;
            }
            else
            {
                txtErrorMessage.Text = "";
                txtErrorMessage.Visible = false;
            }

            //Verificar se email já exite

            return allValid;
        }

        private bool ValidateEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool ValidateField(TextBox textBox, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text);
            errorLabel.Visible = !isValid;
            return isValid;
        }


    }
}
