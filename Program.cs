using System;
using abstract_RPG_POO.src.Entities;

namespace abstract_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem darkKnight = new Personagem("GuintherBK", "Dark Knight");
            Personagem darkWizard = new Personagem("GuintherSM", "Dark Wizard");

            Console.WriteLine(darkKnight.ToString());
            Console.WriteLine("Olá, " + darkWizard.Nome + ", o mundo de Mu Online te espera.");
        }
    }
}
