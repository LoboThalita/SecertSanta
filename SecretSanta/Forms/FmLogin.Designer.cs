namespace SecretSanta.Forms
{
    partial class FmLogin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            tbEmail = new TextBox();
            txtPassword = new TextBox();
            btnTogglePassword = new Button();
            toolTipPassword = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 20F, FontStyle.Bold);
            label1.Location = new Point(157, 29);
            label1.Name = "label1";
            label1.Size = new Size(556, 57);
            label1.TabIndex = 1;
            label1.Text = "Bem-Vindo ao Amigo Secreto";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(401, 130);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(59, 28);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(401, 217);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(325, 316);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 9;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(441, 316);
            button2.Name = "button2";
            button2.Size = new Size(97, 27);
            button2.TabIndex = 9;
            button2.Text = "Criar Conta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(194, 161);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(472, 27);
            tbEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(194, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(472, 27);
            txtPassword.TabIndex = 10;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.AccessibleDescription = "";
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.Font = new Font("Segoe UI", 9F);
            btnTogglePassword.Location = new Point(672, 248);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(30, 29);
            btnTogglePassword.TabIndex = 11;
            btnTogglePassword.Text = "👁";
            toolTipPassword.SetToolTip(btnTogglePassword, "Exibir Senha");
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // FmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 397);
            Controls.Add(btnTogglePassword);
            Controls.Add(txtPassword);
            Controls.Add(tbEmail);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmLogin";
            Text = "Desenvolvido por Thalita Helena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox tbEmail;
        private TextBox txtPassword;
        private Button btnTogglePassword;
        private ToolTip toolTipPassword;
    }
}