using System;

public class ListaSimplesmenteEncadeada
{
    private No Primeiro { get; set; }
    private No Ultimo { get; set; }

    public void Inserir(Carro carro)
    {
        No novoNo = new No(carro);

        if (Primeiro == null)
        {
            Primeiro = novoNo;
            Ultimo = novoNo;
        }
        else
        {
            Ultimo.Proximo = novoNo;
            Ultimo = novoNo;
        }
    }

    public bool Consultar(string nomeModelo)
    {
        No atual = Primeiro;

        while (atual != null)
        {
            if (atual.Dado.NomeModelo == nomeModelo)
                return true;

            atual = atual.Proximo;
        }

        return false;
    }

    public void Remover()
    {
        if (Primeiro == null)
            throw new InvalidOperationException("A lista está vazia.");

        if (Primeiro == Ultimo)
        {
            Primeiro = null;
            Ultimo = null;
            return;
        }

        No atual = Primeiro;

        while (atual.Proximo != Ultimo)
            atual = atual.Proximo;

        atual.Proximo = null;
        Ultimo = atual;
    }

    public void Percorrer()
    {
        No atual = Primeiro;

        while (atual != null)
        {
            Console.WriteLine("Modelo: " + atual.Dado.NomeModelo);
            Console.WriteLine("Fabricante/Montadora: " + atual.Dado.FabricanteMontadora);
            Console.WriteLine("Data de Fabricação: " + atual.Dado.DataFabricacao);
            Console.WriteLine("Preço: " + atual.Dado.Preco);
            Console.WriteLine();

            atual = atual.Proximo;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ListaSimplesmenteEncadeada lista = new ListaSimplesmenteEncadeada();

        lista.Inserir(new Carro("Modelo1", "M1", new DateTime(2020, 1, 1), 10000));
        lista.Inserir(new Carro("Modelo2", "M2", new DateTime(2021, 2, 2), 20000));
        lista.Inserir(new Carro("Modelo3", "M3", new DateTime(2022, 3, 3), 30000));

        bool existeElemento = lista.Consultar("Modelo2");
        Console.WriteLine($"Existe na lista? " + existeElemento);
        Console.WriteLine();

  
        lista.Remover();
        lista.Percorrer();
    }
}
