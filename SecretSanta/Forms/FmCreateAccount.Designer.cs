namespace SecretSanta.Forms
{
    partial class FmCreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            button2 = new Button();
            txtPasswordConfirm = new TextBox();
            label5 = new Label();
            txtErrorMessage = new Label();
            TxtNameError = new Label();
            TxtEmailError = new Label();
            TxtPasswordError = new Label();
            txtCornfirmPasswordError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 20F, FontStyle.Bold);
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 57);
            label1.TabIndex = 1;
            label1.Text = "Criar Conta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(169, 64);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 5;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(169, 149);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(169, 236);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(169, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(537, 27);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(169, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(537, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(169, 267);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(537, 27);
            txtPassword.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(386, 449);
            button2.Name = "button2";
            button2.Size = new Size(97, 27);
            button2.TabIndex = 12;
            button2.Text = "Criar Conta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordConfirm.Location = new Point(169, 355);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.Size = new Size(537, 27);
            txtPasswordConfirm.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(169, 324);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 13;
            label5.Text = "Confirmar Senha:";
            // 
            // txtErrorMessage
            // 
            txtErrorMessage.AutoSize = true;
            txtErrorMessage.Font = new Font("Segoe UI", 7F);
            txtErrorMessage.ForeColor = Color.DarkRed;
            txtErrorMessage.Location = new Point(169, 425);
            txtErrorMessage.Name = "txtErrorMessage";
            txtErrorMessage.Size = new Size(106, 15);
            txtErrorMessage.TabIndex = 15;
            txtErrorMessage.Text = "Mensagem de erro";
            txtErrorMessage.Visible = false;
            // 
            // TxtNameError
            // 
            TxtNameError.AutoSize = true;
            TxtNameError.Font = new Font("Segoe UI", 7F);
            TxtNameError.ForeColor = Color.DarkRed;
            TxtNameError.Location = new Point(169, 125);
            TxtNameError.Name = "TxtNameError";
            TxtNameError.Size = new Size(104, 15);
            TxtNameError.TabIndex = 15;
            TxtNameError.Text = "Nome Obrigatório";
            TxtNameError.Visible = false;
            // 
            // TxtEmailError
            // 
            TxtEmailError.AutoSize = true;
            TxtEmailError.Font = new Font("Segoe UI", 7F);
            TxtEmailError.ForeColor = Color.DarkRed;
            TxtEmailError.Location = new Point(169, 210);
            TxtEmailError.Name = "TxtEmailError";
            TxtEmailError.Size = new Size(100, 15);
            TxtEmailError.TabIndex = 15;
            TxtEmailError.Text = "Email Obrigatório";
            TxtEmailError.Visible = false;
            // 
            // TxtPasswordError
            // 
            TxtPasswordError.AutoSize = true;
            TxtPasswordError.Font = new Font("Segoe UI", 7F);
            TxtPasswordError.ForeColor = Color.DarkRed;
            TxtPasswordError.Location = new Point(169, 297);
            TxtPasswordError.Name = "TxtPasswordError";
            TxtPasswordError.Size = new Size(102, 15);
            TxtPasswordError.TabIndex = 15;
            TxtPasswordError.Text = "Senha Obrigatória";
            TxtPasswordError.Visible = false;
            // 
            // txtCornfirmPasswordError
            // 
            txtCornfirmPasswordError.AutoSize = true;
            txtCornfirmPasswordError.Font = new Font("Segoe UI", 7F);
            txtCornfirmPasswordError.ForeColor = Color.DarkRed;
            txtCornfirmPasswordError.Location = new Point(169, 385);
            txtCornfirmPasswordError.Name = "txtCornfirmPasswordError";
            txtCornfirmPasswordError.Size = new Size(190, 15);
            txtCornfirmPasswordError.TabIndex = 15;
            txtCornfirmPasswordError.Text = "Confirmação de Senha Obrigatória";
            txtCornfirmPasswordError.Visible = false;
            // 
            // FmCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 488);
            Controls.Add(txtCornfirmPasswordError);
            Controls.Add(TxtPasswordError);
            Controls.Add(TxtEmailError);
            Controls.Add(TxtNameError);
            Controls.Add(txtErrorMessage);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FmCreateAccount";
            Text = "Desenvolvido por Thalita Helena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button button2;
        private TextBox txtPasswordConfirm;
        private Label label5;
        private Label txtErrorMessage;
        private Label TxtNameError;
        private Label TxtEmailError;
        private Label TxtPasswordError;
        private Label txtCornfirmPasswordError;
    }
}