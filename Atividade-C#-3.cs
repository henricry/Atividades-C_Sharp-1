// using System ;
// public class Program {
// 	public static void Main () {
// //   Cofre conta= new Cofre (500);
//   conta.ExibirDados();
// 		Usuario u = new Usuario ("Carro2026");
// 		u.ExibirDados();
//  Termometro temp = new Termometro (-400);
//  temp.ExibirDados();
//  Pessoa henri = new Pessoa (120);
//   henri.ExibirDados();
// 		Mago mestre = new Mago(500);
// 		mestre.ExibirDados();
// 		mestre.LancarFeiticio(100);
// 		mestre.ExibirDados();
// 	}
// }
// public class Cofre {
// 	private double saldo;
// 	public Cofre (double saldo) {
// 		this.saldo=saldo;
// 	}
// 	public void Depositar(double valor) {
// 		if (valor > 0) {
// 			saldo += valor;
// 			Console.WriteLine("Deposito Realizado");
// 		}
// 	}
// 	public double VerSaldo () {
// 		return saldo;
// 	}
// 	public void ExibirDados(){
// 	    Console.WriteLine($"O saldo atual C) {this.saldo}");
// 	}
// }

// public class Usuario {
// 	private string senha= "";
// 	public Usuario(string senha){
// 	    this.senha= senha;
// 	}
// 	public void DefinirSenha (string novaSenha) {
// 		if (novaSenha.Length >= 6) {
// 			senha=novaSenha;
// 		}
// 	}
// 	public void ExibirDados() {
// 		Console.WriteLine($"Senha Definida");
// 	}
// }

// public class Termometro {
//     private double temperatura;
//     public Termometro (double temperatura){
//         this.temperatura = temperatura;
//     }
//     public void AlterarTemperatura (double nova){
//         if (nova>= -273)
//         temperatura = nova;
//     }
//     public void ExibirDados(){
//         Console.WriteLine($"A temperatura nova C) {temperatura}");
//     }

// }

// public class Pessoa{
//     public int idade;
//     public Pessoa (int idade){
//         this.idade = idade;
//     }
//     public void DefinirIdade (int idade){
//         if (idade <=0 || idade>=120 )
//         Console.WriteLine($"Valor Invalido");
//     }
//     public void ExibirDados (){
//         Console.WriteLine ($"A Idade de valor {idade} C) invalida");
//     }
// }

// public class Mago {
// 	private int mana;
// 	public Mago (int mana) {
// 		this.mana = mana;
// 	}
// 	public void LancarFeiticio (int custo) {
// 		if (custo <= mana)
// 			this.mana -= custo;
// 		Console.WriteLine($"O custo da magia {custo}");
// 	}
// 	public void ExibirDados() {
// 		Console.WriteLine($"A mana igual a {mana}");
// 	}
// }