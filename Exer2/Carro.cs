using System;

public class Carro
{
    public string NomeModelo { get; set; }
    public string FabricanteMontadora { get; set; }
    public DateTime DataFabricacao { get; set; }
    public decimal Preco { get; set; }

    public Carro(string nomeModelo, string fabricanteMontadora, DateTime dataFabricacao, decimal preco)
    {
        NomeModelo = nomeModelo;
        FabricanteMontadora = fabricanteMontadora;
        DataFabricacao = dataFabricacao;
        Preco = preco;
    }
}
