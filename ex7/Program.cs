//Desenvolva um sistema de gerenciamento de contas bancárias com diferentes tipos de contas, como conta corrente, conta poupança e conta empresarial. Utilize herança para representar a relação entre as classes de contas e implemente métodos específicos para cada tipo de conta, como calcular juros para contas poupança e verificar saldo mínimo para contas empresariais.
ContaPoupanca conta1 = new ContaPoupanca();
conta1.valor = 1000;
double jurosP = conta1.jurosPoupanca();

ContaCorrente conta2 = new ContaCorrente();
conta2.valor = 1000;
double jurosC = conta2.jurosCorrente();

ContaEmpresarial conta3 = new ContaEmpresarial;
conta3.valor = 2000;
double permissao = conta3.minimoEmpresarial();

ContaEmpresarial conta4 = new ContaEmpresarial;
conta4.valor = 2000;
double permissao2 = conta3.minimoEmpresarial();
