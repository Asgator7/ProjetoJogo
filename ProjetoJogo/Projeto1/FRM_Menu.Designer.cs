namespace Projeto1 {
    partial class FRM_Menu {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Cadastro = new System.Windows.Forms.Button();
            this.CMD_Login = new System.Windows.Forms.Button();
            this.CMD_Jogar = new System.Windows.Forms.Button();
            this.CMD_ComoJogar = new System.Windows.Forms.Button();
            this.CMD_Voltar = new System.Windows.Forms.Button();
            this.CMD_Retornar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.rankingToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.cadastroToolStripMenuItem.Text = "Ajuda";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.rankingToolStripMenuItem.Text = "Ranking";
            this.rankingToolStripMenuItem.Click += new System.EventHandler(this.rankingToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // CMD_Cadastro
            // 
            this.CMD_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Cadastro.Location = new System.Drawing.Point(289, 187);
            this.CMD_Cadastro.Name = "CMD_Cadastro";
            this.CMD_Cadastro.Size = new System.Drawing.Size(164, 42);
            this.CMD_Cadastro.TabIndex = 2;
            this.CMD_Cadastro.Text = "Cadastro";
            this.CMD_Cadastro.UseVisualStyleBackColor = true;
            this.CMD_Cadastro.Click += new System.EventHandler(this.CMD_Cadastro_Click);
            // 
            // CMD_Login
            // 
            this.CMD_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Login.Location = new System.Drawing.Point(289, 119);
            this.CMD_Login.Name = "CMD_Login";
            this.CMD_Login.Size = new System.Drawing.Size(164, 42);
            this.CMD_Login.TabIndex = 3;
            this.CMD_Login.Text = "Login";
            this.CMD_Login.UseVisualStyleBackColor = true;
            this.CMD_Login.Click += new System.EventHandler(this.CMD_Login_Click);
            // 
            // CMD_Jogar
            // 
            this.CMD_Jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Jogar.Location = new System.Drawing.Point(289, 152);
            this.CMD_Jogar.Name = "CMD_Jogar";
            this.CMD_Jogar.Size = new System.Drawing.Size(164, 42);
            this.CMD_Jogar.TabIndex = 4;
            this.CMD_Jogar.Text = "Jogar";
            this.CMD_Jogar.UseVisualStyleBackColor = true;
            this.CMD_Jogar.Visible = false;
            this.CMD_Jogar.Click += new System.EventHandler(this.CMD_Jogar_Click);
            // 
            // CMD_ComoJogar
            // 
            this.CMD_ComoJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_ComoJogar.Location = new System.Drawing.Point(254, 225);
            this.CMD_ComoJogar.Name = "CMD_ComoJogar";
            this.CMD_ComoJogar.Size = new System.Drawing.Size(234, 42);
            this.CMD_ComoJogar.TabIndex = 5;
            this.CMD_ComoJogar.Text = "Como jogar";
            this.CMD_ComoJogar.UseVisualStyleBackColor = true;
            this.CMD_ComoJogar.Visible = false;
            this.CMD_ComoJogar.Click += new System.EventHandler(this.CMD_ComoJogar_Click);
            // 
            // CMD_Voltar
            // 
            this.CMD_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Voltar.Location = new System.Drawing.Point(12, 300);
            this.CMD_Voltar.Name = "CMD_Voltar";
            this.CMD_Voltar.Size = new System.Drawing.Size(164, 42);
            this.CMD_Voltar.TabIndex = 6;
            this.CMD_Voltar.Text = "Voltar";
            this.CMD_Voltar.UseVisualStyleBackColor = true;
            this.CMD_Voltar.Visible = false;
            this.CMD_Voltar.Click += new System.EventHandler(this.CMD_Voltar_Click);
            // 
            // CMD_Retornar
            // 
            this.CMD_Retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Retornar.Location = new System.Drawing.Point(615, 300);
            this.CMD_Retornar.Name = "CMD_Retornar";
            this.CMD_Retornar.Size = new System.Drawing.Size(164, 42);
            this.CMD_Retornar.TabIndex = 7;
            this.CMD_Retornar.Text = "Retornar";
            this.CMD_Retornar.UseVisualStyleBackColor = true;
            this.CMD_Retornar.Visible = false;
            this.CMD_Retornar.Click += new System.EventHandler(this.CMD_Retornar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Jogo dos erros";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 354);
            this.Controls.Add(this.CMD_Retornar);
            this.Controls.Add(this.CMD_Voltar);
            this.Controls.Add(this.CMD_ComoJogar);
            this.Controls.Add(this.CMD_Jogar);
            this.Controls.Add(this.CMD_Login);
            this.Controls.Add(this.CMD_Cadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button CMD_Cadastro;
        private System.Windows.Forms.Button CMD_Login;
        private System.Windows.Forms.Button CMD_Jogar;
        private System.Windows.Forms.Button CMD_ComoJogar;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.Button CMD_Voltar;
        private System.Windows.Forms.Button CMD_Retornar;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

