// 
Console.WriteLine("POO - Programação Orientada a Objetos");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Juju";
funcionario.Salario = 2200.0;
funcionario.ValeRefeicao = 949.0;

double aumento = 2000.00;
funcionario.AumentaSalario(aumento);

Console.WriteLine($"O nome do funcionário é {funcionario.Nome} \nE seu salário é de {funcionario.Salario:c} por mês \nCom o vale refeição de {funcionario.ValeRefeicao:c} mensais.");


Console.WriteLine("Qualquer tecla para encerrar..");
Console.ReadKey();