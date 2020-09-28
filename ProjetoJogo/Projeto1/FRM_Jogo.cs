using Projeto1.Properties;
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
    public partial class FRM_Jogo : Form {
        List<Jogador> listJ = new List<Jogador>();
        bool erro1 = false, erro2 = false, erro3 = false, erro4 = false, erro5 = false, erro6 = false, erro7 = false;
        string errosAchados;
        int erros = 0, pontos = 0;
        int minutos = 0, segundos = 0;
        string tempo;
        string login, senha;
        int I = 0;
        public FRM_Jogo() {
            InitializeComponent();
        }

        private void resetar() {
            timer1.Enabled = false;
            PB_PrimeiroErro.Visible = false;
            PB_Erro2.Visible = false;
            PB_Erro3.Visible = false;
            PB_Erro4.Visible = false;
            PB_Erro5.Visible = false;
            PB_Erro6.Visible = false;
            PB_Erro7.Visible = false;
            pictureBox1.Visible = false;
            PGB_ErrosAchados.Visible = false;
            LBL_ErrosAchados.Visible = false;
            LBL_Tempo.Visible = false;
            button1.Visible = true;
            PGB_ErrosAchados.Value = 0;
            segundos = 1;
            minutos = 0;
            erro1 = false;
            erro2 = false;
            erro3 = false;
            erro4 = false;
            erro5 = false;
            erro6 = false;
            erro7 = false;
            PB_PrimeiroErro.Image = Properties.Resources.TerceiroErro;
            PB_Erro2.Image = Properties.Resources.QuartoErro;
            PB_Erro3.Image = Properties.Resources.ErroFinal;
            PB_Erro4.Image = Properties.Resources.SextoErro;
            PB_Erro5.Image = Properties.Resources.QuintoErro;
            PB_Erro6.Image = Properties.Resources.SegundoErro;
            PB_Erro7.Image = Properties.Resources.PrimeiroErro;
            erros = 0;
            errosAchados = "0 / 7";
            LBL_ErrosAchados.Text = errosAchados;
            pontos = 0;
        }

        private void comecarJogo () {
            timer1.Enabled = true;
            PB_PrimeiroErro.Visible = true;
            PB_Erro2.Visible = true;
            PB_Erro3.Visible = true;
            PB_Erro4.Visible = true;
            PB_Erro5.Visible = true;
            PB_Erro6.Visible = true;
            PB_Erro7.Visible = true;
            pictureBox1.Visible = true;
            PGB_ErrosAchados.Visible = true;
            LBL_ErrosAchados.Visible = true;
            LBL_Tempo.Visible = true;
            button1.Visible = false;
        }

        internal List<Jogador> ListJ { get => listJ; set => listJ = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

        private void FRM_Jogo_Load(object sender, EventArgs e) {
            resetar();
        }

        private void button1_Click(object sender, EventArgs e) {
            comecarJogo();
        }


        private void timer1_Tick(object sender, EventArgs e) {
            tempo = minutos.ToString() + " : " + segundos.ToString();
            segundos++;
            if (segundos == 60) {
                segundos = 0;
                minutos++;
            }
            if ((minutos == 5 && segundos == 1) || PGB_ErrosAchados.Value > 6) {
                I = 0;
                listJ.ForEach(delegate (Jogador j1) {
                    if (listJ[I].NomeDeUsuario == Login && listJ[I].Senha == Senha) {
                        listJ[I].Pontuacao = pontos;
                        listJ[I].Tempo = tempo;
                        timer1.Stop();
                        MessageBox.Show("Parabéns " + listJ[I].NomeDeUsuario + "! Você fez " + pontos + " pontos!");
                        return;
                    }
                    I++;
                });
            }
            LBL_Tempo.Text = tempo;
        }


        private void PB_PrimeiroErro_Click_1(object sender, EventArgs e) {
            if (!erro1) {
                PGB_ErrosAchados.Value += 1;
                erro1 = true;
                PB_PrimeiroErro.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }
        }

        private void PB_Erro2_Click(object sender, EventArgs e) {
            if (!erro2) {
                PGB_ErrosAchados.Value += 1;
                erro2 = true;
                PB_Erro2.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }

        }

        private void PB_Erro4_Click(object sender, EventArgs e) {
            if (!erro4) {
                PGB_ErrosAchados.Value += 1;
                erro4 = true;
                PB_Erro4.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }
        }

        private void PB_Erro5_Click(object sender, EventArgs e) {
            if (!erro5) {
                PGB_ErrosAchados.Value += 1;
                erro5 = true;
                PB_Erro5.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }
        }

        private void PB_Erro3_Click(object sender, EventArgs e) {
            if (!erro3) {
                PGB_ErrosAchados.Value += 1;
                erro3 = true;
                PB_Erro3.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }
        }

        private void PB_Erro6_Click(object sender, EventArgs e) {
            if (!erro6) {
                PGB_ErrosAchados.Value += 1;
                erro6 = true;
                PB_Erro6.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }
        }

        private void PB_Erro7_Click(object sender, EventArgs e) {
            if (!erro7) {
                PGB_ErrosAchados.Value += 1;
                erro7 = true;
                PB_Erro7.Image = Properties.Resources.correto;
                erros++;
                errosAchados = erros + " / 7";
                LBL_ErrosAchados.Text = errosAchados;
                pontos++;
            }
        }
    }
}
