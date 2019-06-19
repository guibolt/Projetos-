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
            double media,contador = 0;
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
                        vetNomes[i] = Convert.ToString(Console.ReadLine());
                      
                        Console.WriteLine("Digite a nota do aluno");
                        vetNotas[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                        contador += vetNotas[i];

                        while (vetNotas[i] > 10 || vetNotas[i] < 0)
                        {
                            Console.WriteLine("Nota Errada");
                            Console.WriteLine("Digite uma nota certa");
                            vetNotas[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }

                        if (vetNotas[i] >= 5)
                        {
                            Console.WriteLine(vetNomes[i] + " você foi aprovado " + " com a nota de: " + vetNotas[i]);
                            aprovados++;
                        }

                        else
                        {
                            Console.WriteLine(vetNomes[i]  +" você foi reprovado "+ " com a nota de: " + vetNotas[i]);
                            reprovados++;
                        }
                    }

                    catch (Exception)
                    {

                        Console.WriteLine("Erro, insira um valor compativel.");
                        i--;

                    }

                }

                //   Calculo da media

                media = contador / 5;
                Console.WriteLine("A media da sala foi: " + media.ToString(CultureInfo.InvariantCulture));

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
