using System;

public class Program {
	public static void Main() {
		//  Carro carro = new Carro ("Chevrolet", 2012);
		//  carro.ExibirDados ();

// 		Pet pokemon = new Pet ("Cyndaquil",100);
// 		pokemon.ExibirDados ();
// 		pokemon.Alimentar(40);
// 		pokemon.ExibirDados();

		//   Arma Espada = new Arma ("Iron Sword", 45);
		//   Espada.ExibirDados ();
		//   Arma Arco = new Arma ("Arco Do Trovao", 55);
		//   Arco.ExibirDados();
// 		Conta nubank = new Conta (2000);
// 		nubank.ExibirDados ();
// 		nubank.Sacar(1000);
// 		nubank.ExibirDados();
// 		Robo Bot = new Robo ("Astro", 100);
// 		Bot.ExibirDados();
// 		Bot.Atacar(30);
// 		Bot.ExibirDados();
// 	}
// }

// public class Carro {
// 	public string marca;
// 	public int Ano;
// 	public Carro (string marca, int Ano) {
// 		this.marca = marca;
// 		this.Ano = Ano;
// 	}
// 	public void ExibirDados () {
// 		Console.WriteLine ($"O carro Marca: {this.marca} foi fabricado em {this.Ano}");
// 	}
// }

// public class Pet {
// 	public string nome;
// 	public int fome;
// 	public Pet (string nome, int fome) {
// 		this.nome = nome;
// 		this.fome = fome;
// 	}
// 	public void ExibirDados () {
// 		Console.WriteLine ($"O pet {this.nome} esta com {this.fome} de fome");
// 	}

// 	public void Alimentar (int comida) {
// 		fome -= comida;
// 	}
// }

// public class Arma {
// 	public string nome;
// 	public int dano;
// 	public Arma (string nome, int dano) {
// 		this.nome = nome;
// 		this.dano = dano;
// 	}
// 	public void ExibirDados () {
// 		Console.WriteLine ($"A arma {this.nome} da {this.dano} de dano");
// 	}
// }

// public class Conta {
// 	public double saldo;
// 	public Conta (double saldo) {
// 		this.saldo= saldo;
// 	}
// 	public void Sacar (double valor) {
// 		if (saldo >= valor) {
// 			saldo -= valor;
// 			Console.WriteLine ("Valor Sacado");
// 		} else {
// 			Console.WriteLine ("Saldo insuficiente");
// 		}
// 	}
// 	public void ExibirDados () {
// 		Console.WriteLine ("Saldo Atual" + saldo);
// 	}
// }


// public class Robo
// {
// 	public string Nome;
// 	public int Energia;
// 	public void Atacar(Robo alvo)
// 	{
// 		if (alvo.Energia > 0)
// 		{
// 			alvo.Energia -= 10;

// 			if (alvo.Energia < 0)
// 				alvo.Energia = 0;

// 			Console.WriteLine($"{Nome} atacou {alvo.Nome}!");
// 			Console.WriteLine($"Energia de {alvo.Nome}: {alvo.Energia}");
// 		}
// 		else
// 		{
// 			Console.WriteLine($"{alvo.Nome} ja esta sem energia.");
// 		}
// 	}
// }