class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"NOME: {nome}");
        Console.WriteLine($"ARTISTA: {artista}");
        Console.WriteLine($"DURAÇÃO: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano plus.");
        }
    }
}