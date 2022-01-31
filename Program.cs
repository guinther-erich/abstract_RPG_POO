using System;
using abstract_RPG_POO.src.Entities;

namespace abstract_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem darkKnight = new Personagem("GuintherBK", "Dark Knight");
            DarkWizard darkWizard = new DarkWizard("GuintherSM", "Dark Wizard");

            Console.WriteLine(darkKnight.Atacar());
            Console.WriteLine(darkWizard.Atacar());
        }
    }
}
