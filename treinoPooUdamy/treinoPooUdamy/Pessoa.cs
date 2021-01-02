using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinoPooUdamy
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string criarTexto()
        {
            string texto = ("Nome: " + nome + "\nIdade :" + idade);
            return texto;
        }
    }
}
