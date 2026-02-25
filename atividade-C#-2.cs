using System;

public class Program {
	public static void Main() {
    // Escudo escudo = new Escudo ("Mao de Deus", 100);
    // escudo.ExibirDados ();
    // escudo.AbsorverDano(20);
    // escudo.ExibirDados ();
    
//  PotePocao vida = new PotePocao ("Vida", 5);
//  vida.ExibirDados ();
//  Celular samsung = new Celular ("A15", 100);
//   samsung.ExibirDados ();
//   samsung.AssistirVideo();
//   samsung.ExibirDados();
//   samsung.Carregar();
//   samsung.ExibirDados();

// 		Elevador elevador = new Elevador (1,600, 200);
// 		elevador.ExibirDados();
// 		elevador.AdicionarCarga(500);
// 		elevador.ExibirDados();

// Mestre mestre = new Mestre ("Miyagi");
//      Aprendiz novato = new Aprendiz ("Ryu", 0);
//      mestre.Treinar(novato);
//      novato.ExibirDados();
     
	}
}

// public class Aprendiz {
// 	public string nome;
// 	public int  nivelExperiencia;
// 	public Aprendiz (string nome, int nivelExperiencia) {
// 		this.nome = nome;
// 		this.nivelExperiencia = 0;
// 	}
// 	public void ExibirDados() {
// 		Console.WriteLine ($"O Aprendiz {nome} tem {nivelExperiencia} de experiencia");
// 	}
// }
// public class Mestre {
// 	public string nome;
// 	public Mestre (string nome) {
// 		this.nome =nome;
// 	}
// 	public void Treinar(Aprendiz aluno) {
// 		aluno.nivelExperiencia += 10;
// 	}
// 	public void ExibirDados () {
// 		Console.WriteLine ($"O Mestre {nome} treinou seu aluno e upou 10 niveis dele");
// 	}
// }

// public class Elevador {
// 	public int Id;
// 	public double pesoMaximo;
// 	public double pesoAtual;
// 	public Elevador (int Id, double pesoMaximo, double pesoAtual)
// 	{
// 		this.Id = Id;
// 		this.pesoMaximo = pesoMaximo;
// 		this.pesoAtual = pesoAtual;
// 	}
// 	public void AdicionarCarga (double pesoItem) {
// 		if (pesoAtual + pesoItem <= pesoMaximo)
// 		pesoAtual += pesoItem;
// 		else
// 			Console.WriteLine ("Alerta: Excesso de peso!");
// 	}
// 	public void ExibirDados () {
// 		Console.WriteLine ($"O elevador {Id} esta com um peso atual de {pesoAtual} e tem peso maximo igual a {pesoMaximo}");
// 	}
// }

//  public class Celular {
//      public string Modelo;
//      public int porcentagemBateria;
//      public Celular (string Modelo, int porcentagemBateria)
//      {
//          this.Modelo= Modelo;
//          this.porcentagemBateria = 100;
//      }
//      public void AssistirVideo(){
//          porcentagemBateria -=5;
//          if (porcentagemBateria < 0)
//          porcentagemBateria = 0;
//      }
//      public void Carregar(){
//          porcentagemBateria = 100;
//      }
//      public void ExibirDados (){
//          Console.WriteLine ($"Celular e modelo {Modelo} e esta com {porcentagemBateria} de bateria");
//      }
//  }
// public class Escudo {
// 	public string nome;
// 	public int resistencia;
// 	public Escudo (string nome, int resistencia)
// 	{
// 		this.nome= nome;
// 		this.resistencia = resistencia;
// 	}
// 	public void ExibirDados(){
// 	    Console.WriteLine ($"O Escudo {this.nome} tem {this.resistencia} de resistencia");
// 	}
// 	public void AbsorverDano (int danoRecebido)
// 	{
// 		resistencia -= danoRecebido;
// 		if (resistencia <= 0)
// 		{
// 			resistencia =0;
// 			Console.WriteLine ("O escudo quebrou");
// 		}

// 	}
// }

// public class PotePocao {
//     public string Tipo;
//     public int Quantidade;
//     public PotePocao (string tipo, int quantidade)
//     {
//         Tipo = tipo;
//         Quantidade = quantidade;
//     }
//     public void UsarDose (){
//         if (Quantidade > 0)
//         Quantidade --;
//         else
//         Console.WriteLine ("Pocao esgotada");
//     }
//     public void ExibirDados (){
//         Console.WriteLine ($"Pocao:{this.Tipo}");
//         Console.WriteLine ($"Quantidade:{this.Quantidade}");
//     }
// }