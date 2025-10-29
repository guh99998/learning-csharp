class ContaBancaria
{
    public int NumeroIndicador { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public int Senha { get; set; }

    public void ExibirInfos()
    {
        Console.WriteLine($"TITULAR DA CONTA: {Titular}");
        Console.WriteLine($"NUMERO DA CONTA: {NumeroIndicador}");
        Console.WriteLine($"SALDO DA CONTA: {Saldo}");
        Console.WriteLine($"SENHA: {Senha}");
    }

}