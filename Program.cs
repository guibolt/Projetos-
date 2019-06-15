using System;

namespace Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {


            // nomes dos alunos 

            //string aluno1, aluno2, aluno3, aluno4, aluno5;
            //int notas1,nota2,nota3,nota4,nota5;

            //string[] vetNomes;

            //vetNomes = new string[4];


             int  media;
             int[] vetNotas;


            int contador = 0;

             string[] s;

             vetNomes = new string[5]; 
             vetNotas = new int[5];
            contNomes = new string[5];
         
            // Nome dos Alunos
            Console.WriteLine("Digite os nomes  dos  Alunos de");


            for(int i = 0; i < 5; i++)
            {

               vetNomes[i] = Convert.ToString(Console.ReadLine());
               contNomes[i] = Convert.ToString(vetNotas[i]);

                

            }
            //  Notas dos allunos 
             Console.WriteLine("Digite as notas  0 a 10");

            

            for ( int p = 0; p<5; p++)
            {
                
                 vetNotas[p] =int.Parse(Console.ReadLine());

                if (vetNotas[p] > 5)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (vetNotas[l] > 5)
                        {
                            Console.WriteLine(vetNomes[l]);

                            Console.WriteLine(vetNotas[p] + "Aprovado");
                        }
                        

                    }
                }
              


                contador = contador + vetNotas[p];

             }
            // Calculo das medias
                 media = contador / 5;
                Console.WriteLine(media);





        }
    }
}
