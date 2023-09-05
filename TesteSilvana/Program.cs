using TesteSilvana;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        funcionarios.Add(new Funcionario("Maria", new DateTime(2000, 10, 18), 2009.44m, "Operador"));
        funcionarios.Add(new Funcionario("João", new DateTime(1990, 05, 12), 2284.38m, "Operador"));
        funcionarios.Add(new Funcionario("Caio", new DateTime(1961, 05, 02), 9836.14m, "Coordenador"));
        funcionarios.Add(new Funcionario("Miguel", new DateTime(1988, 10, 14), 9836.14m, "Diretor"));
        funcionarios.Add(new Funcionario("Alice", new DateTime(1995, 01, 05), 2234.68m, "Recepcionista"));
        funcionarios.Add(new Funcionario("Heitor", new DateTime(1999, 11, 19), 1582.72m, "Recepcionista"));
        funcionarios.Add(new Funcionario("Arthur", new DateTime(1993, 03, 31), 4071.84m, "Contador"));
        funcionarios.Add(new Funcionario("Laura", new DateTime(1994, 07, 08), 3017.45m, "Gerente"));
        funcionarios.Add(new Funcionario("Heloisa", new DateTime(2003, 05, 24), 1606.85m, "Gerente"));
        funcionarios.Add(new Funcionario("Heloisa", new DateTime(2003, 05, 24), 1606.85m, "Eletricista"));

        funcionarios.RemoveAll(x => x.Nome == "João");

        foreach(var funcionario in funcionarios)
        {
            Console.WriteLine(funcionario.ToString());
        }

        foreach(var funcionario in funcionarios)
        {
            funcionario.Salario *= 1.1m;
        }

        Dictionary<string, List<Funcionario>> funcionariosPorFuncao = new Dictionary<string, List<Funcionario>>();

        foreach (var funcionario in funcionarios)
        {
            if (!funcionariosPorFuncao.ContainsKey(funcionario.Funcao))
            {
                funcionariosPorFuncao[funcionario.Funcao] = new List<Funcionario>();
            }

            funcionariosPorFuncao[funcionario.Funcao].Add(funcionario);
        }

        foreach (var grupo in funcionariosPorFuncao)
        {
            Console.WriteLine($"Função: {grupo.Key}");
            foreach(var funcionario in grupo.Value)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }

        var funcionariosAniversario = funcionarios
            .Where(f => f.DataDeNascimento.Month == 10 || f.DataDeNascimento.Month == 12)
            .ToList();

        Console.WriteLine("Funcionários que fazem aniversário em outubro e dezembro: ");
        foreach(var funcionario in funcionariosAniversario)
        {
            Console.WriteLine(funcionario.ToString());
        }

        var funcionarioMaisVelho = funcionarios
            .OrderByDescending(f => DateTime.Now.Year - f.DataDeNascimento.Year)
            .First();

        Console.WriteLine($"Funcionário mais velho: {funcionarioMaisVelho.Nome}");

        var funcionariosOrdenados = funcionarios
            .OrderBy(f => f.Nome).ToList();

        Console.WriteLine("Funcionários em ordem alfabética: ");
        foreach(var funcionario in funcionariosAniversario)
        {
            Console.WriteLine(funcionario.ToString());
        }

        decimal totalSalarios = funcionarios.Sum(f => f.Salario);
        Console.WriteLine($"Total dos salários dos funcionários: {totalSalarios:C}");

        decimal salarioMinimo = 1212.00m;
        foreach(var funcionario in funcionarios)
        {
            decimal salarioSalariosMinimos = funcionario.Salario / salarioMinimo;
            Console.WriteLine($"{funcionario.Nome} ganha {salarioSalariosMinimos} salários mínimos");
        }
    }

}