public class Produto
{
    public double preco;
    public int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 10;
        }
    }
    public string ProdutoDetalhado => $"Nome: {Nome} | Marca: {Marca} | Preço: {Preco} | Qtd_Estoque: {Estoque}";

}