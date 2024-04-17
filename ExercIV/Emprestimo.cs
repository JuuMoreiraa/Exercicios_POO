public class Emprestimo : Servico
{
    public Emprestimo()
    {

    }

    public double Valor { get; set; }
    public int Parcelas { get; set; }
    public double Taxa { get; set; }

    public double Parcelar(double Valor, double Taxa, int Parcelas)
    {
        double calculo = Valor*Taxa;
        return calculo/Parcelas;
    }
}

