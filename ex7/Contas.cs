public class Contas{
    public double valor { get; set; }
    public int tempo { get; set; }
    public double saldo { get; set; }
    public double juros { get; set; }

    public Contas (double valor, int tempo, double saldo, double juros){
        valor = valor;
        tempo = tempo;
        saldo = saldo;
        juros = juros;
    }
}