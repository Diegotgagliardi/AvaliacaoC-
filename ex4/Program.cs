Produto produto01 = new Produto("Cabo de celular", 10.50, 33);

produto01.adicionarEstoque(12);
double adicionarTotal = produto01.valorTotal();

produto01.removerEstoque(33);
double removerTotal = produto01.valorTotal();
