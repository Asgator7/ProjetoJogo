namespace Projeto1 {
    partial class FRM_Jogo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Jogo));
            this.PGB_ErrosAchados = new System.Windows.Forms.ProgressBar();
            this.LBL_ErrosAchados = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PB_Erro3 = new System.Windows.Forms.PictureBox();
            this.PB_Erro4 = new System.Windows.Forms.PictureBox();
            this.PB_Erro5 = new System.Windows.Forms.PictureBox();
            this.PB_PrimeiroErro = new System.Windows.Forms.PictureBox();
            this.PB_Erro2 = new System.Windows.Forms.PictureBox();
            this.PB_Erro6 = new System.Windows.Forms.PictureBox();
            this.PB_Erro7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_Tempo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PrimeiroErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PGB_ErrosAchados
            // 
            this.PGB_ErrosAchados.Location = new System.Drawing.Point(12, 12);
            this.PGB_ErrosAchados.Maximum = 7;
            this.PGB_ErrosAchados.Name = "PGB_ErrosAchados";
            this.PGB_ErrosAchados.Size = new System.Drawing.Size(629, 38);
            this.PGB_ErrosAchados.TabIndex = 8;
            this.PGB_ErrosAchados.Visible = false;
            // 
            // LBL_ErrosAchados
            // 
            this.LBL_ErrosAchados.AutoSize = true;
            this.LBL_ErrosAchados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ErrosAchados.Location = new System.Drawing.Point(660, 21);
            this.LBL_ErrosAchados.Name = "LBL_ErrosAchados";
            this.LBL_ErrosAchados.Size = new System.Drawing.Size(63, 29);
            this.LBL_ErrosAchados.TabIndex = 9;
            this.LBL_ErrosAchados.Text = "0 / 7";
            this.LBL_ErrosAchados.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PB_Erro3
            // 
            this.PB_Erro3.Image = global::Projeto1.Properties.Resources.ErroFinal;
            this.PB_Erro3.Location = new System.Drawing.Point(1488, 375);
            this.PB_Erro3.Name = "PB_Erro3";
            this.PB_Erro3.Size = new System.Drawing.Size(56, 38);
            this.PB_Erro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Erro3.TabIndex = 7;
            this.PB_Erro3.TabStop = false;
            this.PB_Erro3.Visible = false;
            this.PB_Erro3.Click += new System.EventHandler(this.PB_Erro3_Click);
            // 
            // PB_Erro4
            // 
            this.PB_Erro4.Image = global::Projeto1.Properties.Resources.SextoErro;
            this.PB_Erro4.Location = new System.Drawing.Point(1457, 511);
            this.PB_Erro4.Name = "PB_Erro4";
            this.PB_Erro4.Size = new System.Drawing.Size(63, 19);
            this.PB_Erro4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Erro4.TabIndex = 6;
            this.PB_Erro4.TabStop = false;
            this.PB_Erro4.Visible = false;
            this.PB_Erro4.Click += new System.EventHandler(this.PB_Erro4_Click);
            // 
            // PB_Erro5
            // 
            this.PB_Erro5.Image = global::Projeto1.Properties.Resources.QuintoErro;
            this.PB_Erro5.Location = new System.Drawing.Point(1610, 576);
            this.PB_Erro5.Name = "PB_Erro5";
            this.PB_Erro5.Size = new System.Drawing.Size(76, 38);
            this.PB_Erro5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Erro5.TabIndex = 5;
            this.PB_Erro5.TabStop = false;
            this.PB_Erro5.Visible = false;
            this.PB_Erro5.Click += new System.EventHandler(this.PB_Erro5_Click);
            // 
            // PB_PrimeiroErro
            // 
            this.PB_PrimeiroErro.Image = global::Projeto1.Properties.Resources.TerceiroErro;
            this.PB_PrimeiroErro.Location = new System.Drawing.Point(1406, 228);
            this.PB_PrimeiroErro.Name = "PB_PrimeiroErro";
            this.PB_PrimeiroErro.Size = new System.Drawing.Size(41, 60);
            this.PB_PrimeiroErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_PrimeiroErro.TabIndex = 4;
            this.PB_PrimeiroErro.TabStop = false;
            this.PB_PrimeiroErro.Visible = false;
            this.PB_PrimeiroErro.Click += new System.EventHandler(this.PB_PrimeiroErro_Click_1);
            // 
            // PB_Erro2
            // 
            this.PB_Erro2.Image = global::Projeto1.Properties.Resources.QuartoErro;
            this.PB_Erro2.Location = new System.Drawing.Point(1406, 285);
            this.PB_Erro2.Name = "PB_Erro2";
            this.PB_Erro2.Size = new System.Drawing.Size(159, 53);
            this.PB_Erro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Erro2.TabIndex = 3;
            this.PB_Erro2.TabStop = false;
            this.PB_Erro2.Visible = false;
            this.PB_Erro2.Click += new System.EventHandler(this.PB_Erro2_Click);
            // 
            // PB_Erro6
            // 
            this.PB_Erro6.Image = global::Projeto1.Properties.Resources.SegundoErro;
            this.PB_Erro6.Location = new System.Drawing.Point(1508, 791);
            this.PB_Erro6.Name = "PB_Erro6";
            this.PB_Erro6.Size = new System.Drawing.Size(36, 29);
            this.PB_Erro6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Erro6.TabIndex = 2;
            this.PB_Erro6.TabStop = false;
            this.PB_Erro6.Visible = false;
            this.PB_Erro6.Click += new System.EventHandler(this.PB_Erro6_Click);
            // 
            // PB_Erro7
            // 
            this.PB_Erro7.Image = global::Projeto1.Properties.Resources.PrimeiroErro;
            this.PB_Erro7.Location = new System.Drawing.Point(1155, 908);
            this.PB_Erro7.Name = "PB_Erro7";
            this.PB_Erro7.Size = new System.Drawing.Size(581, 126);
            this.PB_Erro7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Erro7.TabIndex = 1;
            this.PB_Erro7.TabStop = false;
            this.PB_Erro7.Visible = false;
            this.PB_Erro7.Click += new System.EventHandler(this.PB_Erro7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1935, 978);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // LBL_Tempo
            // 
            this.LBL_Tempo.AutoSize = true;
            this.LBL_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Tempo.Location = new System.Drawing.Point(1822, 21);
            this.LBL_Tempo.Name = "LBL_Tempo";
            this.LBL_Tempo.Size = new System.Drawing.Size(62, 29);
            this.LBL_Tempo.TabIndex = 10;
            this.LBL_Tempo.Text = "0 : 0";
            this.LBL_Tempo.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(906, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Começar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_Tempo);
            this.Controls.Add(this.LBL_ErrosAchados);
            this.Controls.Add(this.PGB_ErrosAchados);
            this.Controls.Add(this.PB_Erro3);
            this.Controls.Add(this.PB_Erro4);
            this.Controls.Add(this.PB_Erro5);
            this.Controls.Add(this.PB_PrimeiroErro);
            this.Controls.Add(this.PB_Erro2);
            this.Controls.Add(this.PB_Erro6);
            this.Controls.Add(this.PB_Erro7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FRM_Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PrimeiroErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Erro7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PB_Erro7;
        private System.Windows.Forms.PictureBox PB_Erro6;
        private System.Windows.Forms.PictureBox PB_Erro2;
        private System.Windows.Forms.PictureBox PB_PrimeiroErro;
        private System.Windows.Forms.PictureBox PB_Erro5;
        private System.Windows.Forms.PictureBox PB_Erro4;
        private System.Windows.Forms.PictureBox PB_Erro3;
        private System.Windows.Forms.ProgressBar PGB_ErrosAchados;
        private System.Windows.Forms.Label LBL_ErrosAchados;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_Tempo;
        private System.Windows.Forms.Button button1;
    }
}