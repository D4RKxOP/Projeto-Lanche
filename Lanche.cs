public class Lanche
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public double Preco { get; set; }

    public Lanche(int codigo, string nome, double preco)
    {
        Codigo = codigo;
        Descricao = nome;
        Preco = preco;
    }
}
