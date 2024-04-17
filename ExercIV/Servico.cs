public class Servico
{
    public string Contratante { get; set; }
    public string Responsavel => "Sistema - Via aplicativo";
    public string DataContrato => DateTime.Now.ToString("dd/MM/yyyy");
}

