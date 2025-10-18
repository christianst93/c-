using Modelo;
using logica;

var p1 = new Produto {
    Descricao = "Mouse Logitech",
    Quantidade = 255,
    Preco = 39.90m
};

Console.WriteLine(p1);

var retorno = Carrinho.CalcularCompra(p1);
Console.WriteLine($"O valor total é R${retorno.total}, foi parcelado em {retorno.parcelas} vez e o valor da parcela é de R${retorno.valorParcela}");
