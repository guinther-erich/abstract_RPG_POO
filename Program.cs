using System;

namespace abstract_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representação de um personagem sem POO
            string nome = "GuintherBK";
            int pontosDeVida = 30;
            int pontosdeMagia = 10;
            string classe = "Dark Knight";

            string nome2 = "GuintherSM";
            int pontosDeVida2 = 10;
            int pontosdeMagia2 = 100;
            string classe2 = "Dark Wizard";

            Console.WriteLine("Olá, " + nome + ", o mundo de Mu Online te espera.");
            Console.WriteLine("Olá, " + nome2 + ", o mundo de Mu Online te espera.");
        }
    }
}
