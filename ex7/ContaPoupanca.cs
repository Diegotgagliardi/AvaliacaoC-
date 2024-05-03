public class ContaPoupanca : Contas{
    public void jurosPoupanca(double valor, int tempo, double juros){
        juros = valor * 0.20 * tempo;
        return juros;
    }
}