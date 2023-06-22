public class No
{
    public Carro Dado { get; set; }
    public No Proximo { get; set; }

    public No(Carro dado)
    {
        Dado = dado;
        Proximo = null;
    }
}
