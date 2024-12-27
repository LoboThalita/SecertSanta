using System.Text.RegularExpressions;

namespace SecretSanta.Forms
{
    public partial class FmCreateAccount : Form
    {
        public FmCreateAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidFields())
            {
                MessageBox.Show("tudo Ok");
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
