public class ContaCorrente : Contas{
public String jurosCorrente(double valor, int tempo, double juros){
        juros = valor * 0.50 * tempo;
        return juros;
    }
}