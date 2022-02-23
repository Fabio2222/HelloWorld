using System;

namespace Hello_World
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, nascimento;
            float altura;
            char sexo;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o ano de seu nascimento: ");
            nascimento = Convert.ToInt32(Console.ReadLine());
            idade = 2022 - nascimento;
            Console.WriteLine("Informe sua altura: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Informe o sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Olá {0}! Voce tem {1} anos e mede {2}", nome, idade, altura);

            if ((sexo == 'F') || (sexo == 'f'))


            if (idade >= 18)
            {
                Console.WriteLine("Parabéns! Você ganhou um prêmio!");
            }
            else
            {
                Console.WriteLine("Já, já é a sua vez!");
            }
            Console.ReadLine();
        }
    }
}
