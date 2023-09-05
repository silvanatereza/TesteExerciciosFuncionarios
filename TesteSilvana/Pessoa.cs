using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSilvana
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Pessoa(string nome, DateTime dataDeNascimento)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
        }

    }
}
