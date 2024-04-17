// POO - Herança
using System.Collections;
using System.Net.WebSockets;

repeat:
Console.WriteLine("Bem vindo(a) á Wheather Seguros \n Selecione a opção desejada: \n[S] Serviços de Seguro Automotivo \n[E] Serviços de Empréstimo \n[X] Sair");
string opcao = Console.ReadLine().ToUpper();

switch (opcao)
{
    case "S":
        TabelaSeguro();
        CondicaoSeguro();
        EfetivaOuNem();
        break;

    case "E":
        
        TabelaEmprestimo();
        CondicaoEmprestimo();
        EfetivaOuNem();
        break;

    case "X":
        Console.WriteLine("Obrigado por nos escolher!\nAté a próxima ;)");
        break;
    default:

        Console.WriteLine("Opção Inválida!\nTente novamente.");
        goto repeat;
}

void EfetivaOuNem()
{
efetivacao:
    Console.WriteLine("Deseja enviar prosseguir para efetivação? \n[S] Sim \n[N] Não");
    string Envio = Console.ReadLine().ToUpper();

    switch (Envio)
    {
        case "S":
            Console.Clear();
            Console.WriteLine("Ficha enviada aos nossos consultores. \nEm um prazo de 48h você receberá o retorno em seu e-mail.");
            break;
        case "N":
            Console.Clear();
            Console.WriteLine("Obrigado por orçamentar conosco! \nVolte sempre!");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            goto efetivacao;
    }
}

void TabelaSeguro()
{
    Console.WriteLine("Você escolheu a opção de Seguro Automotivo!\n");
    Console.WriteLine("  --Ano--  \t --Seguro--\t--Franquia--");
    Console.WriteLine("2000 a 2010\tR$18.000,00\tR$6.000,00");
    Console.WriteLine("2011 a 2020\tR$48.000,00\tR$16.000,00");
    Console.WriteLine("2021 a 2024\tR$66.000,00\tR$22.000,00\n");
}

void TabelaEmprestimo()
{
    Console.WriteLine("Você escolheu a opção de empréstimo!\n");
    Console.WriteLine("      --Valor--         \t--Parcelas-- \t--Taxa--");
    Console.WriteLine("R$1.000,00 a R$5.000,00   \t     12x     \t  28%\t");
    Console.WriteLine("R$5.001,00 a R$10.000,00  \t     24x     \t  52%\t");
    Console.WriteLine("R$10.001,00 a R$20.000,00 \t     48x     \t  68%\t");
}

void CondicaoSeguro()
{
    SeguroVeiculo seguro = new SeguroVeiculo();
    Console.Write("Por favor, nos informe o nome do contratante: ");
    seguro.Contratante = Console.ReadLine();
    Console.Write("Informe o veículo:  ");
    seguro.Veiculo = Console.ReadLine();
    Console.Write("Por favor, nos informe o ano do veículo: ");
    seguro.AnoVeiculo = int.Parse(Console.ReadLine());
    if (seguro.AnoVeiculo < 2000 || seguro.AnoVeiculo > 2024)
    {
        Console.WriteLine($"Infelizmente não cobrimos seguro para carros do ano {seguro.AnoVeiculo}.");
    }
    else
    {
        if (seguro.AnoVeiculo >= 2000 && seguro.AnoVeiculo <= 2010)
        {
            seguro.PrecoSeguro = 18000;
            seguro.PrecoFranquia = 6000;

        }
        else if (seguro.AnoVeiculo >= 2011 && seguro.AnoVeiculo <= 2020)
        {
            seguro.PrecoSeguro = 48000;
            seguro.PrecoFranquia = 16000;
        }
        else
        {
            seguro.PrecoSeguro = 66000;
            seguro.PrecoFranquia = 22000;
        }
    }
    Console.Clear();
    Console.WriteLine("Ficha de cotação concluída com sucesso! \nConfira abaixo:");
    Console.WriteLine($"Contratante: {seguro.Contratante} \nResponsável: {seguro.Responsavel} \nData do contrato: {seguro.DataContrato} \nVeículo: {seguro.Veiculo} \nAno do veículo: {seguro.AnoVeiculo} \nPreço do seguro: {seguro.PrecoSeguro:c} \nValor da franquia: {seguro.PrecoFranquia:c}");
}

void CondicaoEmprestimo()
{
    Emprestimo emprestimo = new Emprestimo();
    Console.Write("Por favor, nos informe o nome do contratante: ");
    emprestimo.Contratante = Console.ReadLine();
    repeatII:
    Console.Write("Informe o valor desejado para empréstimo: ");
    emprestimo.Valor = double.Parse(Console.ReadLine());

    if (emprestimo.Valor < 1000 || emprestimo.Valor > 20000)
    {
        Console.WriteLine("Valor inválido\nTente novamente.");
        goto repeatII;
    }
    else
    {
        if (emprestimo.Valor >= 1000 && emprestimo.Valor <= 5000)
        {
            emprestimo.Parcelas = 12;
            emprestimo.Taxa = 1.28;
        }
        else if (emprestimo.Valor >= 5001 && emprestimo.Valor <= 10000)
        {
            emprestimo.Parcelas = 24;
            emprestimo.Taxa = 1.52;
        }
        else
        {
            emprestimo.Parcelas = 48;
            emprestimo.Taxa = 1.68;
        }
    }
    Console.Clear();
    Console.WriteLine("Ficha de cotação concluída com sucesso! \nConfira abaixo:");
    Console.WriteLine($"Contratante: {emprestimo.Contratante} \nResponsável: {emprestimo.Responsavel} \nData do contrato: {emprestimo.DataContrato} \nValor do empréstimo: {emprestimo.Valor} \nTaxa: {emprestimo.Taxa}% \nQuantidade de parcelas: {emprestimo.Parcelas}x \nValor Parcela: {emprestimo.Parcelar(emprestimo.Valor, emprestimo.Taxa, emprestimo.Parcelas):c}");
}
