//Crie uma classe Produto que represente um produto em uma loja online. A classe deve ter os seguintes atributos: Nome, Preco, QuantidadeEmEstoque. Implemente métodos para adicionar e remover unidades do estoque, e um método para calcular o valor total do produto em estoque. Os métodos devem alterar o estado do objeto instanciado
public class Produto{

    public string nome { get; set; }
    public double preco { get; set; }
    public int qtdEstoque { get; set; }

    public Produto (string nome, double preco, int qtdEstoque){
        nome = nome;
        preco = preco;
        qtdEstoque = qtdEstoque;
    }

    public void adicionarEstoque(int qtd){
        qtdEstoque += qtd;
    }

    public void removerEstoque(int qtd){
        qtdEstoque -= qtd;
    }

    public double valorTotal(){
        return preco * qtdEstoque;
    }

}