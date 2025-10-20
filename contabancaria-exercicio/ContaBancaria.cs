class ContaBancaria
{
    public int numeroIndicador;
    public string titular;
    public double saldo;
    public int senha;

    public void ExibirInfos()
    {
        Console.WriteLine($"TITULAR DA CONTA: {titular}");
        Console.WriteLine($"NUMERO DA CONTA: {numeroIndicador}");
        Console.WriteLine($"SALDO DA CONTA: {saldo}");
        Console.WriteLine($"SENHA: {senha}");
    }

}