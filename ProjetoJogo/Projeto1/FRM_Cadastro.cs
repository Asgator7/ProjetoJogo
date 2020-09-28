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
    public partial class FRM_Cadastro : Form {
        List<Jogador> listJ = new List<Jogador>();
        Jogador J;
        bool sen = true, senOK = true;

        public void clearAll () {
            TXT_Nome.Clear();
            TXT_Senha.Clear();
            TXT_SenhaOK.Clear();
            TXT_Sobrenome.Clear();
            TXT_NomeDeUsuario.Clear();
            dateTimePicker1.Value = dateTimePicker1.MinDate;
        }

        internal List<Jogador> ListJ { get => listJ; set => listJ = value; }

        public FRM_Cadastro() {
            InitializeComponent();
        }

        private void CMD_SenOK_Click(object sender, EventArgs e) {
            if (!senOK) {
                TXT_SenhaOK.UseSystemPasswordChar = true;
                senOK = true;
            }
            else {
                TXT_SenhaOK.UseSystemPasswordChar = false;
                senOK = false;
            }
        }

        private void CMD_Ok_Click(object sender, EventArgs e) {
            if (TXT_Senha.Text == TXT_SenhaOK.Text) {
                J = new Jogador();
                J.NomeCompleto = TXT_Nome.Text + " " + TXT_Sobrenome.Text;
                J.Senha = TXT_Senha.Text;
                J.DataNascimento = dateTimePicker1.Value;
                J.NomeDeUsuario = TXT_NomeDeUsuario.Text;
                ListJ.Add(J);
                clearAll();
                MessageBox.Show("Cadastro feito com sucesso!");
            }
            else MessageBox.Show("As senhas não coincidem!");
        }

        private void FRM_Cadastro_Load(object sender, EventArgs e) {
            clearAll();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if ((TXT_Nome.Text == "") || (TXT_Sobrenome.Text == "") || (TXT_Senha.Text == "") || (TXT_SenhaOK.Text == "") || (TXT_NomeDeUsuario.Text == "")) {
                CMD_Ok.Enabled = false;
            }
            else CMD_Ok.Enabled = true;
        }

        private void CMD_Sen_Click(object sender, EventArgs e) {
            if (!sen) {
                TXT_Senha.UseSystemPasswordChar = true;
                sen = true;
            }

            else {
                TXT_Senha.UseSystemPasswordChar = false;
                sen = false;
            }
        }
    }
}
