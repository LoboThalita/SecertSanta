using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSanta.Forms
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnTogglePassword.Text = "🙈";
                toolTipPassword.SetToolTip(btnTogglePassword, "Ocultar senha");
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnTogglePassword.Text = "👁";
                toolTipPassword.SetToolTip(btnTogglePassword, "Exibir senha");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar no banco se email e senha existe

            //Se existe vai para o formulario de lista de jogos

            //Se não existe Aparece label de usuario inválido
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FmCreateAccount frm = new FmCreateAccount();
            frm.Show();
        }
    }
}
