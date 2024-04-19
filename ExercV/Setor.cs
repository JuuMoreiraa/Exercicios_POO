using System.Data;

public class Setor
{
    public int IdSetor { get; set; }
    public string NomeSetor { get; set; }

    void TabelaSetor()
    {
        int [] row = 4;
        int [] col = 2;
        string [,] S = new string [row, col];
        //Cabeçalho
        S[0,0] = "IdSetor";
        S[0,1] = "NomeSetor";
        //Linha I
        S[1,0] = "1";
        S[1,1] = "Administrativo";
        //Linha II
        S[2,0] = "2";
        S[2,1] = "Produção";
        //Linha III
        S[3,0] = "3";
        S[3,1] = "Comercial";

        for (int = 0; < length;++)
        {
            
        }
    }
}