using System;

namespace Funções___Atividade
{
    class Program
    {   
        static float CalcularMedia( float[] numeros){

            float soma = 0;

            for(var i = 0; i < numeros.Length; i++){
                soma += numeros[i];
            }

            float resultado = soma / numeros.Length;

            return resultado;
        }
            
        static void Main(string[] args)
        {   
            string[] nomes = new string[2];
            float[] medias = new float[2];
            float[] notas = new float[4];

            for(int i = 0; i < nomes.Length; i++){
                Console.WriteLine("Digite um nome de aluno:");
                nomes[i] = Console.ReadLine();

                for(int n = 0; n < notas.Length; n++){
                    Console.WriteLine($"Digite a {(n+1)}º nota:");
                    notas[n] = float.Parse(Console.ReadLine());
                }

                medias[i] = CalcularMedia(notas);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            foreach(string nome_a_vulso in nomes){
                Console.WriteLine(nome_a_vulso);
            }
            
            for(var i = 0; i < nomes.Length; i++){
                Console.WriteLine($"Nome: {nomes[i]} -- Média: {medias[i]}");
            }
            
            Console.ResetColor();
            
            Console.WriteLine("Média geral da turma: " + CalcularMedia(medias));
        }
    }
}
