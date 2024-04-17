// POO - Herança
using System.Collections;

repeat:
Console.WriteLine("Bem vindo(a) á Wheather Seguros \n Selecione a opção desejada: \n[S] Serviços de Seguro \n[E] Serviços de Empréstimo \n[X] Sair");
string opcao = Console.ReadLine().ToUpper();

switch (opcao)
{
    case "S":
        SeguroVeiculo seguro = new SeguroVeiculo();
        Console.Write("Por favor, nos informe o nome do contratante: ");
        seguro.Contratante = Console.ReadLine();
        Console.Write("Informe o veículo:  ");
        seguro.Veiculo = Console.ReadLine();
        Console.Write("Por favor, nos informe o nome do contratante: ");
        seguro.AnoVeiculo = int.Parse(Console.ReadLine());

        if(seguro.AnoVeiculo >= 2000 && seguro.AnoVeiculo <= 2010){
            seguro.PrecoSeguro = 18000;
            seguro.PrecoFranquia = 6000;

        } else if (seguro.AnoVeiculo >= 2011 && seguro.AnoVeiculo <= 2020){
            seguro.PrecoSeguro = 48000;
            seguro.PrecoFranquia = 16000;
        } else {
            seguro.PrecoSeguro = 66000;
            seguro.PrecoFranquia = 22000;
        }
        Console.Clear();
        Console.WriteLine("Ficha de cotação concluída com sucesso! \nConfira abaixo:");
        Console.WriteLine($"Contratante: {seguro.Contratante} \nResponsável: {seguro.Responsavel} \nData do contrato: {seguro.DataContrato} \nVeículo: {seguro.Veiculo} \nAno do veículo: {seguro.AnoVeiculo} \nPreço do seguro: {seguro.PrecoSeguro:c} \nValor da franquia: {seguro.PrecoFranquia:c}");
        efetivaounem();
        break;
        
    case "E":
        Emprestimo emprestimo = new Emprestimo();
        Console.WriteLine("Valor mínimo disponível para empréstimo: R$1000,00 \nValor máximo disponível para empréstimo: R$20.000,00");
        Console.Write("Por favor, nos informe o nome do contratante: ");
        emprestimo.Contratante = Console.ReadLine();
        repeatII:
        Console.Write("Informe o valor desejado para empréstimo: ");
        emprestimo.Valor = double.Parse(Console.ReadLine());

        if (emprestimo.Valor < 1000 || emprestimo.Valor >20000) {
            Console.WriteLine("Valor inválido, Tente novamente.");
            goto repeatII;
        } else{
            if(emprestimo.Valor >= 1000 && emprestimo.Valor <= 5000){
                emprestimo.Parcelas = 12;
                emprestimo.Taxa = 1.28;
            } else if (emprestimo.Valor >= 5001 && emprestimo.Valor <= 10000){
                emprestimo.Parcelas = 24;
                emprestimo.Taxa = 1.52;
            } else {
                emprestimo.Parcelas = 48;
                emprestimo.Taxa = 1.68;
            }
        }
        Console.Clear();
        Console.WriteLine("Ficha de cotação concluída com sucesso! \nConfira abaixo:");
        Console.WriteLine($"Contratante: {emprestimo.Contratante} \nResponsável: {emprestimo.Responsavel} \nData do contrato: {emprestimo.DataContrato} \nValor do empréstimo: {emprestimo.Valor} \nTaxa: {emprestimo.Taxa}% \nQuantidade de parcelas: {emprestimo.Parcelas}x \nValor Parcela: {emprestimo.Parcelar(emprestimo.Valor, emprestimo.Taxa, emprestimo.Parcelas):c}");
        efetivaounem();
        break;

    case "X":
        Console.WriteLine("Obrigado por nos escolher!\nAté a próxima ;)");
        break;
    default:
    
        Console.WriteLine("Opção Inválida!\nTente novamente.");
        goto repeat;
}



void efetivaounem() {
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