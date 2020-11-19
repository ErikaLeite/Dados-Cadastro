using System;

namespace Dados_Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia e valide as seguintes informações:

            // 1. Nome: diferente de vazio;
            // 2. Idade: entre 0 e 150;
            // 3. Salário: maior que zero;
            // 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

            string undefined = null;
            Console.WriteLine("Olá!\nSeja Bem-vindo(a)");
            Console.WriteLine("  ");
            Console.WriteLine("FAÇA SEU CADASTRO");
            Console.WriteLine("  ");

            //NOME
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            undefined = Console.ReadLine();
            
            while(nome == undefined){
                Console.Write("Por favor, insira seu nome: ");
                nome = Console.ReadLine();
                undefined = Console.ReadLine();
            }

            //IDADE
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            while(idade < 0 || idade > 150){
                Console.Write("Insira uma idade válida: ");
                idade = int.Parse(Console.ReadLine());
            }

            //SALÁRIO
            Console.Write("Qual o seu salário? ");
            float salario = float.Parse(Console.ReadLine());
            while(salario < 1){
                Console.Write("Insira um valor válido: ");
                salario = float.Parse(Console.ReadLine());
            }

            //ESTADO CIVIL
            // string S, C, V, D;
            Console.WriteLine("Qual o seu Estado Civil?\nESCOLHA UMA DAS OPÇÕES ABAIXO: \nS - (Solteiro(a)\nC - (Casado(a)\nV - (Viúvo(a))\nD - (Divorciado(a)");
            string estado = Console.ReadLine();
            // while(estado == S; C; V; D){
                
            // }
            Console.Write("CADASTRO FINALIZADO");
        }
    }
}
