using System;
using System.Globalization;
namespace Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetNomes = new string[5];
            double[] vetNotas = new double[5];
            double  nota=0, contador = 0;
            int porc,aprovados =0,reprovados=0;
            char tecla = 's';

            do
            {
                for (int i = 0; i < 5; i++)
                {
              
                    try
                    {
                        // Nome dos Alunos
                        Console.WriteLine("Digite o nome do aluno: ");
                        string nome = Convert.ToString(Console.ReadLine());
                        vetNomes[i] = nome;

                        Console.WriteLine("Digite a nota do aluno");
                        nota = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                        vetNotas[i] = nota;

                        contador += vetNotas[i];

                        while (nota > 10 || nota < 0)
                        {
                            Console.WriteLine("Nota Errada");
                            Console.WriteLine("Digite uma nota certa");
                            nota = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }

                        if (vetNotas[i] >= 5)
                        {
                            Console.WriteLine("Voce foi aprovado " + vetNomes[i] + " Com a nota de: " + vetNotas[i]);
                            aprovados++;
                        }

                        else
                        {
                            Console.WriteLine("Voce foi reprovado " + vetNomes[i] + " Com a nota de: " + vetNotas[i]);
                            reprovados++;
                        }
                    }

                    catch (Exception)
                    {

                        Console.WriteLine("Erro, insira um valor compativel.");
                        i--;

                    }

                }

                //   Calculo das medias
                Console.WriteLine("A media da sala foi: " + contador / 5);

                // Calculo da porcentagem
                porc = aprovados * 20;
                Console.WriteLine("A % de Alunos aprovados é: " + porc);

                porc = reprovados * 20;
                Console.WriteLine("A % de Alunos reprovados é: " + porc);

                Console.WriteLine("Deseja calcular novamente ? s para sim e n para não!");

                tecla = char.Parse(Console.ReadLine());
                Console.Clear();
                
            } while (tecla == 's');

        }
    }
}
