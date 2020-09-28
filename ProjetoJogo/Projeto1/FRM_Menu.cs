using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1 {
    public partial class FRM_Menu : Form {
        List<Jogador> listJ = new List<Jogador>();
        Jogador J;
        FRM_Cadastro Cad = new FRM_Cadastro();
        FRM_Login Log = new FRM_Login();
        FRM_Jogo Jogo = new FRM_Jogo();
        FRM_Ranking Rank;
        FRM_ComoJogar ComoJ;
        FRM_Ajuda Help;

        string login, senha;

        internal List<Jogador> ListJ { get => listJ; set => listJ = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

        public FRM_Menu() {
            InitializeComponent();
        }


        private void CMD_Login_Click(object sender, EventArgs e) {
            Log.ListJ = listJ;
            Log.ShowDialog();
            if (Log.Ok) {
                Login = Log.Login;
                Senha = Log.Senha;
                CMD_Jogar.Visible = true;
                CMD_ComoJogar.Visible = true;
                CMD_Cadastro.Visible = false;
                CMD_Login.Visible = false;
                CMD_Voltar.Visible = true;
            }
        }

        private void CMD_Cadastro_Click(object sender, EventArgs e) {
            listJ = Cad.ListJ;
            Cad.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Dispose();
        }


        private void FRM_Menu_Load(object sender, EventArgs e) {
            notifyIcon1.BalloonTipText = "Aplicação minimizada";
            notifyIcon1.BalloonTipTitle = "Jogo dos 7 erros";
        }

        private void CMD_Jogar_Click(object sender, EventArgs e) {
            Jogo.ListJ = listJ;
            Jogo.Login = Login;
            Jogo.Senha = Senha;
            Jogo.ShowDialog();
        }

        private void CMD_Voltar_Click(object sender, EventArgs e) {
            CMD_Jogar.Visible = false;
            CMD_ComoJogar.Visible = false;
            CMD_Login.Visible = true;
            CMD_Cadastro.Visible = true;
            CMD_Voltar.Visible = false;
            CMD_Retornar.Visible = true;
        }

        private void CMD_Retornar_Click(object sender, EventArgs e) {
            CMD_Jogar.Visible = true;
            CMD_ComoJogar.Visible = true;
            CMD_Cadastro.Visible = false;
            CMD_Login.Visible = false;
            CMD_Voltar.Visible = true;
            CMD_Retornar.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
        }

        private void CMD_ComoJogar_Click(object sender, EventArgs e) {
            ComoJ = new FRM_ComoJogar();
            ComoJ.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e) {
            Help = new FRM_Ajuda();
            Help.ShowDialog();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e) {
            Rank = new FRM_Ranking();
            Rank.ListJ = listJ;
            Rank.ShowDialog();
        }
    }
}
