// Herança em POO

Console.WriteLine("Poo - Herança");
Funcionario funcionario = new Funcionario();
Console.WriteLine("Cadastro de novos funcionários");
Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Cargo: ");
funcionario.Cargo = Console.ReadLine();
Console.Write("Salario: ");
funcionario.Salario = double.Parse(Console.ReadLine());
Console.Write("Setor: ");
funcionario.NomeSetor = Console.ReadLine();

Console.Clear();
Console.WriteLine($"Cadastro realizado! \nFicha Funcional \nNome: {funcionario.Nome} \nCargo: {funcionario.Cargo} \nSalario: {funcionario.Salario:c}                               \nSetor Alocado: {funcionario.NomeSetor}");


Console.ReadKey();