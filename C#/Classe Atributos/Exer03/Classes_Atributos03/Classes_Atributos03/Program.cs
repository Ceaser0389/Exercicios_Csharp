using System;
using System.Globalization;

namespace Classes_Atributos03
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.WriteLine(" Entre com o nome do aluno :");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Entre com as três notas do aluno :");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal().ToString("F2"), CultureInfo.InvariantCulture);

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO ");
            }
            else
            {
                Console.WriteLine("REPROVADO ");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS ");


            }
















        }
    }
}
