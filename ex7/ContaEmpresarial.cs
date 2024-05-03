public class ContaEmpresarial : Contas{
    public void minimoEmpresarial(double saldo){
        if(saldo > 1000){
            Console.WriteLine("Aprovado");
        }
        else{
            Console.WriteLine("Negado");
        }
    }
}