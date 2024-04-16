// Veiculos com Poo Herança //

//Entrada
Console.WriteLine("POO - Veículos");
repeat1:
Console.WriteLine("Qual tipo de veículo você deseja orçamentar? \n[1] Automóveis \n[2] Motocicletas \n[3] Helicoptero \n[0] Sair");
string opcao = Console.ReadLine();

//Processamento
void Carro()
{
    Automovel automovel = new Automovel();
    Console.WriteLine("Preencha a ficha:");
    Console.Write("Marca: ");
    automovel.Marca = Console.ReadLine();
    Console.Write("Modelo: ");
    automovel.Modelo = Console.ReadLine();
    Console.Write("Ano de fabricação desejada: ");
    automovel.AnoFabricacao = int.Parse(Console.ReadLine());
    Console.Write("Valor: ");
    automovel.Preco = double.Parse(Console.ReadLine());
    Console.Write("Aro da roda: ");
    automovel.RodasAro = int.Parse(Console.ReadLine());
    Console.Write("Tipo de Câmbio: ");
    automovel.Cambio = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Solicitação de cotação realizada com sucesso! \nFicha de orçamento: \nMarca: {automovel.Marca} \nModelo: {automovel.Modelo} \nAno Fabricação: {automovel.AnoFabricacao} \nValor veículo: {automovel.Preco:c} \nTamanho Rodas: {automovel.RodasAro} \nTipo Câmbio: {automovel.Cambio}");
}

void Moto()
{
    Motocicleta motocicleta = new Motocicleta();
    Console.WriteLine("Preencha a ficha:");
    Console.Write("Marca: ");
    motocicleta.Marca = Console.ReadLine();
    Console.Write("Modelo: ");
    motocicleta.Modelo = Console.ReadLine();
    Console.Write("Ano de fabricação desejada: ");
    motocicleta.AnoFabricacao = int.Parse(Console.ReadLine());
    Console.Write("Valor: ");
    motocicleta.Preco = double.Parse(Console.ReadLine());
    Console.Write("Tipo transmissão desejada: ");
    motocicleta.Transmissao = Console.ReadLine();
    Console.Write("Potência do motor: ");
    motocicleta.PotenciaMotor = double.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"Solicitação de cotação realizada com sucesso! \nFicha de orçamento: \nMarca: {motocicleta.Marca} \nModelo: {motocicleta.Modelo} \nAno Fabricação: {motocicleta.AnoFabricacao} \nValor veículo: {motocicleta.Preco:c} \nTransmissão: {motocicleta.Transmissao} \nPotência Motor: {motocicleta.PotenciaMotor}cv");
}

void Heli()
{
    Helicoptero helicoptero = new Helicoptero();
    Console.WriteLine("Preencha a ficha:");
    Console.Write("Marca: ");
    helicoptero.Marca = Console.ReadLine();
    Console.Write("Modelo: ");
    helicoptero.Modelo = Console.ReadLine();
    Console.Write("Ano de fabricação desejada: ");
    helicoptero.AnoFabricacao = int.Parse(Console.ReadLine());
    Console.Write("Valor: ");
    helicoptero.Preco = double.Parse(Console.ReadLine());
    Console.Write("Capacidade: ");
    helicoptero.CapacidadePessoas = int.Parse(Console.ReadLine());
    Console.Write("Carga Mínima: ");
    helicoptero.Carga = double.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"Solicitação de cotação realizada com sucesso! \nFicha de orçamento: \nMarca: {helicoptero.Marca} \nModelo: {helicoptero.Modelo} \nAno Fabricação: {helicoptero.AnoFabricacao} \nValor veículo: {helicoptero.Preco:c} \nCapacidade de pessoas: {helicoptero.CapacidadePessoas} \nCarga Mínima: {helicoptero.Carga}kg");
}

switch (opcao)
{
    case "0":
        Console.Clear();
        Console.WriteLine("Até a próxima! ;)");
        break;
    case "1":
        Carro();
        break;
    case "2":
        Moto();
        break;
    case "3":
        Heli();
        break;
    default:
        Console.Clear();
        Console.WriteLine("Opção inválida! Tente novamente.");
        goto repeat1;
}

Console.ReadKey();

