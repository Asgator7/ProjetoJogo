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
    public partial class FRM_Login : Form {
        List<Jogador> listJ = new List<Jogador>();
        bool sen = true, ok;
        int I = 0;
        string login, senha;

        public bool confirmacaoLoginSenha() {
            bool confirmacao = false;
            I = 0;
            listJ.ForEach(delegate (Jogador J1) {
                if ((listJ[I].NomeDeUsuario == TXT_Login.Text) && (listJ[I].Senha == TXT_Senha.Text)) {
                    Login = listJ[I].NomeDeUsuario;
                    Senha = listJ[I].Senha;
                    confirmacao = true;
                    return;
                }
                I++;
            });
            if (confirmacao) {
                ok = true;
                return true;
            }
            else {
                ok = false;
            return false;
            }
        }

        public void clearAll() {
            TXT_Login.Clear();
            TXT_Senha.Clear();
        }

        public FRM_Login() {
            InitializeComponent();
        }

        internal List<Jogador> ListJ { get => listJ; set => listJ = value; }
        public bool Ok { get => ok; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

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

        private void FRM_Login_Load(object sender, EventArgs e) {
            clearAll();
        }

        private void CMD_Ok_Click(object sender, EventArgs e) {
            if (confirmacaoLoginSenha()) {
                MessageBox.Show("Login efetuado com sucesso!");
                
                clearAll();
            }
            else MessageBox.Show("Usuário e senha não correspondem!");
        }

        //private void TXT_Senha_KeyPress(object sender, KeyPressEventArgs e) {
        //    if (confirmacaoLoginSenha()) {
        //        MessageBox.Show("Login efetuado com sucesso!");
        //        clearAll();
        //    }
        //    else MessageBox.Show("Usuário e senha não correspondem!");
        //}

        private void timer1_Tick(object sender, EventArgs e) {
            if ((TXT_Login.Text == "") || (TXT_Senha.Text == "")) {
                CMD_Ok.Enabled = false;
            }
            else CMD_Ok.Enabled = true;
        }
    }
}
