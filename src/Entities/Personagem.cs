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
	}
}

