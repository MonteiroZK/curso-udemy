using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace treinoPooUdamy
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotalEstoque()
        {
            double valor = Preco * Quant;
            return valor;
        }

        public void AdicionarEstoque(int valor)
        {
            Quant = Quant + valor;
        }
        public void RemoverEstoque(int valor)
        {
            Quant = Quant - valor;
        }

        public override string ToString()
        {
            return "Dados do produto: " + Nome + ", $" + Preco + ", " + Quant + "unidade" + ", Total: $" + ValorTotalEstoque();
        }

    }
}
