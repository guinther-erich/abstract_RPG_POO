using System;

namespace abstract_RPG_POO.src.Entities
{
	public class Personagem
	{
		public Personagem(string Nome, string Classe)
		{
			this.Nome = Nome;
			this.Classe = Classe;
			this.Level = 1;
			this.PontosDeVida = 10;
			this.PontosDeMagia = 10;
		}

		public string Nome { get; set; }
		public int Level { get; set; }
		public int PontosDeVida { get; set; }
		public int PontosDeMagia { get; set; }
		public string Classe { get; set; }

		public override string ToString()
        {
			return "Olá, " + this.Nome + ", o mundo de Mu Online te espera.\n"
				+ "Seu nível é: " + this.Level + ".\n"
				+ "A classe que você escolheu foi: " + this.Classe + ".\n"
				+ "Seus pontos de vida são: " + this.PontosDeVida + ". E seus pontos de magia são: " + this.PontosDeMagia + ".";
        }

		public virtual string Atacar()
        {
			Random dado = new Random();
			int forcaDoAtaque = this.Level + dado.Next(1,20);

			return this.Nome + " atacou o seu oponente com um dano de " + forcaDoAtaque + " pontos.";
			
        }
	}
}

