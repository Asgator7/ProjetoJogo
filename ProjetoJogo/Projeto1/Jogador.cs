using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1 {
    class Jogador {
        string nomeCompleto, senha, nomeDeUsuario, tempo;
        DateTime dataNascimento;
        int pontuacao;

        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Senha { get => senha; set => senha = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string NomeDeUsuario { get => nomeDeUsuario; set => nomeDeUsuario = value; }
        public string Tempo { get => tempo; set => tempo = value; }
        public int Pontuacao { get => pontuacao; set => pontuacao = value; }
    }
}
