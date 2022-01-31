using System;

namespace abstract_RPG_POO.src.Entities
{
	public class DarkWizard : Personagem
	{
		public DarkWizard(string Nome, string Classe) : base(Nome, Classe)
        {
			this.Nome = Nome;
			this.Classe = Classe;
			this.Level = 1;
			this.PontosDeVida = 10;
			this.PontosDeMagia = 10;
		}

		public override string Atacar()
        {
			Random dado = new Random();
			int forcaDoAtaque = this.Level + dado.Next(1, 10);
			return this.Nome + " atacou o seu oponente com o seu cajado e desferiu um dano de " + forcaDoAtaque + " pontos.";

		}
	}
}