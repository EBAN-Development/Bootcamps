/* 
Platform: Digital Innovation One - DIO
BootCamp: WEX - End to End Engineering
Developer: André Bezerra
Collaborator(s): [...]
Module: Controle e Análise de Transações com POO em C#
Challenge: 1 / 2 - Controle de Limite do Cartão Corporativo
*/

/* 
TODO:
    1. [x]imprima o total gasto com duas casas decimais  e;
    2. [x] uma mensagem informando se o limite foi ultrapassado ou não;
    3. [x] adicione a transação à instância do cartão
*/

using System;
using System.Collections.Generic;
using System.Linq;

class CartaoCorporativo {
    
    public double Limite { get; }
    public List<double> Transacoes { get; }

    public CartaoCorporativo(double limite) {
        
        Limite = limite;
        Transacoes = new List<double>();
        
    }

    public void AdicionarTransacao(double valor) {
        // TODO [x]adicione o valor à lista Transacoes
        Transacoes.Add(valor);
    }

    public void ExibirResumo() {
        
        // 1 e 2
        Console.WriteLine($"Total gasto: {Transacoes.Sum():F2}\n
                        {Transacoes.Sum() > Limite ? "Limite ultrapassado" : "Limite OK"}"
                        );
    }
}

class WEE25_221 {

    static void Main() {
        
        double valor, limite = double.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        var cartao = new CartaoCorporativo(limite);

        for (int i = 0; i < quantidade; ++i) {
            
            valor = double.Parse(Console.ReadLine());
            
            // 3
            cartao.AdicionarTransacao(valor);
        }

        cartao.ExibirResumo();
    }
}
