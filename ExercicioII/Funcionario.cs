public class Funcionario : Setor
{
    //Construtor da classe permite que sejam definidos valores padrão de início da instanciação da classe
    public Funcionario()
    {

    }

    //Propriedades
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double ValeRefeicao { get; set; }
    
    //Procedimento => ação
    public double AumentaSalario(double aumento)
    {

        return Salario += aumento;
    }

}