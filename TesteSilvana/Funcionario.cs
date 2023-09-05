using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSilvana
{
    internal class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Funcao { get; set; }

        public Funcionario(string nome, DateTime dataDeNascimento, decimal salario, string funcao) : base(nome, dataDeNascimento)
        {
            Salario = salario;
            Funcao = funcao;
        }

        public override string? ToString()
        {
            return $"Nome: {Nome}, Data de Nascimento: {DataDeNascimento: dd/MM/yyyy}, Salário: {Salario:C}, Função: {Funcao}";
        }
    }
}
