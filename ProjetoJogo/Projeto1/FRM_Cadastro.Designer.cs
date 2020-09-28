namespace Projeto1 {
    partial class FRM_Cadastro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Nome = new System.Windows.Forms.TextBox();
            this.TXT_Sobrenome = new System.Windows.Forms.TextBox();
            this.TXT_Senha = new System.Windows.Forms.TextBox();
            this.TXT_SenhaOK = new System.Windows.Forms.TextBox();
            this.CMD_Ok = new System.Windows.Forms.Button();
            this.CMD_Sen = new System.Windows.Forms.Button();
            this.CMD_SenOK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TXT_NomeDeUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar senha";
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Nome.Location = new System.Drawing.Point(278, 65);
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.Size = new System.Drawing.Size(218, 34);
            this.TXT_Nome.TabIndex = 6;
            // 
            // TXT_Sobrenome
            // 
            this.TXT_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Sobrenome.Location = new System.Drawing.Point(278, 111);
            this.TXT_Sobrenome.Name = "TXT_Sobrenome";
            this.TXT_Sobrenome.Size = new System.Drawing.Size(218, 34);
            this.TXT_Sobrenome.TabIndex = 7;
            // 
            // TXT_Senha
            // 
            this.TXT_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Senha.Location = new System.Drawing.Point(278, 218);
            this.TXT_Senha.Name = "TXT_Senha";
            this.TXT_Senha.Size = new System.Drawing.Size(218, 34);
            this.TXT_Senha.TabIndex = 9;
            this.TXT_Senha.UseSystemPasswordChar = true;
            // 
            // TXT_SenhaOK
            // 
            this.TXT_SenhaOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SenhaOK.Location = new System.Drawing.Point(278, 274);
            this.TXT_SenhaOK.Name = "TXT_SenhaOK";
            this.TXT_SenhaOK.Size = new System.Drawing.Size(218, 34);
            this.TXT_SenhaOK.TabIndex = 10;
            this.TXT_SenhaOK.UseSystemPasswordChar = true;
            // 
            // CMD_Ok
            // 
            this.CMD_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Ok.Location = new System.Drawing.Point(343, 343);
            this.CMD_Ok.Name = "CMD_Ok";
            this.CMD_Ok.Size = new System.Drawing.Size(75, 40);
            this.CMD_Ok.TabIndex = 11;
            this.CMD_Ok.Text = "OK";
            this.CMD_Ok.UseVisualStyleBackColor = true;
            this.CMD_Ok.Click += new System.EventHandler(this.CMD_Ok_Click);
            // 
            // CMD_Sen
            // 
            this.CMD_Sen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMD_Sen.BackgroundImage")));
            this.CMD_Sen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMD_Sen.Location = new System.Drawing.Point(517, 218);
            this.CMD_Sen.Name = "CMD_Sen";
            this.CMD_Sen.Size = new System.Drawing.Size(42, 34);
            this.CMD_Sen.TabIndex = 12;
            this.CMD_Sen.TabStop = false;
            this.CMD_Sen.UseVisualStyleBackColor = true;
            this.CMD_Sen.Click += new System.EventHandler(this.CMD_Sen_Click);
            // 
            // CMD_SenOK
            // 
            this.CMD_SenOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMD_SenOK.BackgroundImage")));
            this.CMD_SenOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMD_SenOK.Location = new System.Drawing.Point(517, 272);
            this.CMD_SenOK.Name = "CMD_SenOK";
            this.CMD_SenOK.Size = new System.Drawing.Size(42, 34);
            this.CMD_SenOK.TabIndex = 13;
            this.CMD_SenOK.TabStop = false;
            this.CMD_SenOK.UseVisualStyleBackColor = true;
            this.CMD_SenOK.Click += new System.EventHandler(this.CMD_SenOK_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 163);
            this.dateTimePicker1.MaxDate = new System.DateTime(2709, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 34);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // TXT_NomeDeUsuario
            // 
            this.TXT_NomeDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NomeDeUsuario.Location = new System.Drawing.Point(278, 17);
            this.TXT_NomeDeUsuario.Name = "TXT_NomeDeUsuario";
            this.TXT_NomeDeUsuario.Size = new System.Drawing.Size(218, 34);
            this.TXT_NomeDeUsuario.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome de usuário";
            // 
            // FRM_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 395);
            this.Controls.Add(this.TXT_NomeDeUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CMD_SenOK);
            this.Controls.Add(this.CMD_Sen);
            this.Controls.Add(this.CMD_Ok);
            this.Controls.Add(this.TXT_SenhaOK);
            this.Controls.Add(this.TXT_Senha);
            this.Controls.Add(this.TXT_Sobrenome);
            this.Controls.Add(this.TXT_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FRM_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FRM_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Nome;
        private System.Windows.Forms.TextBox TXT_Sobrenome;
        private System.Windows.Forms.TextBox TXT_Senha;
        private System.Windows.Forms.TextBox TXT_SenhaOK;
        private System.Windows.Forms.Button CMD_Ok;
        private System.Windows.Forms.Button CMD_Sen;
        private System.Windows.Forms.Button CMD_SenOK;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TXT_NomeDeUsuario;
        private System.Windows.Forms.Label label6;
    }
}