namespace Projeto1 {
    partial class FRM_Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.TXT_Login = new System.Windows.Forms.TextBox();
            this.TXT_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMD_Ok = new System.Windows.Forms.Button();
            this.CMD_Sen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TXT_Login
            // 
            this.TXT_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Login.Location = new System.Drawing.Point(360, 62);
            this.TXT_Login.Name = "TXT_Login";
            this.TXT_Login.Size = new System.Drawing.Size(242, 34);
            this.TXT_Login.TabIndex = 0;
            // 
            // TXT_Senha
            // 
            this.TXT_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Senha.Location = new System.Drawing.Point(360, 120);
            this.TXT_Senha.Name = "TXT_Senha";
            this.TXT_Senha.Size = new System.Drawing.Size(175, 34);
            this.TXT_Senha.TabIndex = 1;
            this.TXT_Senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome de usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // CMD_Ok
            // 
            this.CMD_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Ok.Location = new System.Drawing.Point(414, 177);
            this.CMD_Ok.Name = "CMD_Ok";
            this.CMD_Ok.Size = new System.Drawing.Size(75, 40);
            this.CMD_Ok.TabIndex = 4;
            this.CMD_Ok.Text = "OK";
            this.CMD_Ok.UseVisualStyleBackColor = true;
            this.CMD_Ok.Click += new System.EventHandler(this.CMD_Ok_Click);
            // 
            // CMD_Sen
            // 
            this.CMD_Sen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMD_Sen.BackgroundImage")));
            this.CMD_Sen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMD_Sen.Location = new System.Drawing.Point(560, 120);
            this.CMD_Sen.Name = "CMD_Sen";
            this.CMD_Sen.Size = new System.Drawing.Size(42, 34);
            this.CMD_Sen.TabIndex = 12;
            this.CMD_Sen.UseVisualStyleBackColor = true;
            this.CMD_Sen.Click += new System.EventHandler(this.CMD_Sen_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 245);
            this.Controls.Add(this.CMD_Sen);
            this.Controls.Add(this.CMD_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Senha);
            this.Controls.Add(this.TXT_Login);
            this.MaximizeBox = false;
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Login;
        private System.Windows.Forms.TextBox TXT_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CMD_Ok;
        private System.Windows.Forms.Button CMD_Sen;
        private System.Windows.Forms.Timer timer1;
    }
}