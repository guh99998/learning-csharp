﻿class Musica
{
    public string Nome {  get; set; }
    public string Artista {  get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"NOME: {Nome}");
        Console.WriteLine($"ARTISTA: {Artista}");
        Console.WriteLine($"DURAÇÃO: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano plus.");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"NOME: {Nome}");
        Console.WriteLine($"ARTISTA: {Artista}");
    }
}