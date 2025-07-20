/* 
Platform: Digital Innovation One - DIO
BootCamp: WEX - End to End Engineering
Developer: André Bezerra
Collaborator(s): [...]
Module: Controle e Análise de Transações com POO em C#
Challenge: 2 / 2 - Identificador de Transações Suspeitas
*/

/* 
TODO:
    1. [x] Crie a Classe AnalisadorDeTransacoes;
    2. [x] adicione a transação à lista Transacoes;
    3. [x] retorne as transações que são superiores ao limite;
    4. [x] Implemente a condição if para retornar uma mensagem informando que não há transações suspeitas;
    5. [x]imprima o total das transações suspeitas com duas casas decimais e;
    6. [x]a quantidade de transações suspeitas;
    7. [x] adicione a transação à instância do analisador.
*/

using System;
using System.Collections.Generic;
using System.Linq;

// 1
class AnalisadorDeTransacoes {
    public double Limite { get; set; }

    // TODO: [x] Crie a lista para armazenar as transações realizadas:
    public List<double> Transacoes { get; set; }

    public AnalisadorDeTransacoes(double limite) {
        Limite = limite;
        Transacoes = new List<double>();
    }

    public void AdicionarTransacao(double valor) {
        // 2
        Transacoes.Add(valor);
    }

    public List<double> ObterTransacoesSuspeitas() {
        // 3
        return Transacoes.Where(t => t > Limite).ToList();
    }

    public void ExibirRelatorio() {
        
        var suspeitas = ObterTransacoesSuspeitas();
        bool flag = suspeitas.Count() == 1;
        string transacao_saida = "Nenhuma transacao suspeita";
        
        // 4
        if (suspeitas.Any()) {
        
            // 5 e 6
            
            transacao_saida = $"Transacoes suspeitas: {suspeitas.Sum():F2}\n
            {suspeitas.Count()} transac{flag ? "ao":"oes"} suspeita{flag ? "":"s"}";
            
        }        
        
        Console.WriteLine(transacao_saida);
    
    }
}

class Program {
    static void Main() {
        
        double valor, limite = double.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        var analisador = new AnalisadorDeTransacoes(limite);

        for (int i = 0; i < quantidade; ++i) {
            
            valor = double.Parse(Console.ReadLine());
            
            // 7
            analisador.AdicionarTransacao(valor);
        }
        
        analisador.ExibirRelatorio();
    }
}
