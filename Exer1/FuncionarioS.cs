namespace Struct;

public struct FuncionarioS
{
    public string nome;
    public string cpf;

    public string cargo;

    public double salario;

    public double carga;

    public FuncionarioS(string nome, string cpf, string cargo, double salario, double carga)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.cargo = cargo;
        this.salario = salario;
        this.carga = carga;
    }

    public void aumentoSalarialPorPromocaoEmValor(double v)
    {
        salario = salario + v;
    }

    public void promover(string novocargo, double aumento)
    {
        cargo = novocargo;
        aumentoSalarialPorPromocaoEmValor(aumento);
    }

    public void descontoSalarialPorFaltaEmValor(double v)
    {
        salario = salario - v;
    }

    public void aumentarCargaHorariaDeTrabalho(double h, double reajuste){
        carga = carga + h;
    }

    public string imprimir(){
        return "\nNome: " + this.nome +
        "\nCPF: " + this.cpf +
        "\nSalario: " + salario +
        "\nCarga Horaria: " + carga + "horas";
    }
}
