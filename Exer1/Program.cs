using Struct;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioS funcionario1 = new();

            funcionario1.nome = "Silva";
            funcionario1.cargo = "Mentoria";
            funcionario1.salario = 1000;
            funcionario1.carga = 20;

            funcionario1.imprimir();

        funcionario1.promover("Coordenador", 2000);
        funcionario1.imprimir();

        funcionario1.descontoSalarialPorFaltaEmValor(200);
        funcionario1.imprimir();

        funcionario1.aumentarCargaHorariaDeTrabalho(10, 0.05);
        funcionario1.imprimir();
        }
    }
}
