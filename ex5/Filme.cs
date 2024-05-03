//Implemente um sistema para uma locadora de filmes. Crie uma classe Filme com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o filme está disponível para locação). Implemente métodos para registrar a locação de um filme, registrar a devolução de um filme e verificar se um filme está disponível para locação. Não há necessidade de implementar rotinas de bancos de dados.

using System.Net.Mime;

public class Filme{
public string Titulo { set; get; }
  public string Genero { set; get; }
  public double Duracao { set; get; }
  public string Disponivel { set; get; }

  public Filme (string Titulo, string Genero, double Duracao, string Disponivel){
    Titulo = Titulo;
    Genero = Genero;
    Duracao = Duracao;
    Disponivel = Disponivel;
  }

  public void Aluguel() {
    if (Disponivel.Equals("n")) {
        Console.WriteLine("Produto não disponível");
    } else {
        Disponivel = "n";
        Console.WriteLine("Aluguel realizado");
    }
}
 
  }
 