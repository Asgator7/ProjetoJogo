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
    public partial class FRM_Ranking : Form {
        List<Jogador> listJ = new List<Jogador>();
        public FRM_Ranking() {
            InitializeComponent();
        }

        internal List<Jogador> ListJ { get => listJ; set => listJ = value; }

        private void FRM_Ranking_Load(object sender, EventArgs e) {
            int I = 0;
            string total = "";
            listJ.ForEach(delegate (Jogador J1) {
                total = listJ[I].NomeDeUsuario + "\t\t\t";
                total += listJ[I].Pontuacao.ToString() + "\t\t\t";
                total += listJ[I].Tempo;
                LBX_RankingGeral.Items.Add(total);
                I++;
            });
        }

        

    }
}
