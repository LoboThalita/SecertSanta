namespace SecretSanta
{
    partial class FmInitial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            textBox1 = new TextBox();
            lbEmailWhats = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 20F, FontStyle.Bold);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 57);
            label1.TabIndex = 0;
            label1.Text = "Amigo Secreto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 1;
            label2.Text = "Deseja enviar o nome por:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 127);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "E-mail";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(134, 127);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(97, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Whatsapp";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(17, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 27);
            textBox1.TabIndex = 5;
            // 
            // lbEmailWhats
            // 
            lbEmailWhats.AutoSize = true;
            lbEmailWhats.Font = new Font("Segoe UI", 12F);
            lbEmailWhats.Location = new Point(403, 190);
            lbEmailWhats.Name = "lbEmailWhats";
            lbEmailWhats.Size = new Size(71, 28);
            lbEmailWhats.TabIndex = 6;
            lbEmailWhats.Text = "E-mail:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(403, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 27);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(794, 230);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 8;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(403, 330);
            button2.Name = "button2";
            button2.Size = new Size(97, 27);
            button2.TabIndex = 8;
            button2.Text = "Ver nomes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FmInitial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 401);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(lbEmailWhats);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmInitial";
            Text = "Desenvolvido por Thalita Helena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private TextBox textBox1;
        private Label lbEmailWhats;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
