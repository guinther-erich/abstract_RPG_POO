using System;
using abstract_RPG_POO.src.Entities;

namespace abstract_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem darkKnight = new Personagem();
            darkKnight.Nome = "GuintherBK";
            darkKnight.Level = 1;
            darkKnight.PontosDeVida = 30;
            darkKnight.PontosDeMagia = 10;
            darkKnight.Classe = "Dark Knight";

            Console.WriteLine("Olá, " + darkKnight.Nome + ", o mundo de Mu Online te espera.");
        }
    }
}
