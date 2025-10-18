namespace logica;
using Modelo;

public static class Carrinho {

    public static (byte parcelas, decimal valorParcela, decimal total) CalcularCompra (Produto p) {

    decimal total = p.Preco * p.Quantidade;
    decimal valorParcela = 0;
    byte parcelas = 0;

    if(total < 200m){
        parcelas = 1;
    } else if(total < 500m) {
        parcelas = 5;
    } else {
        parcelas = 10;
    }

    valorParcela = total / parcelas;

    return (parcelas, valorParcela,total);
 }
}