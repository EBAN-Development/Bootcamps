/* 
Platform: Digital Innovation One - DIO
BootCamp: WEX - End to End Engineering
Developer: André Bezerra
Collaborator(s): [...]
Module: Filtrando Dados e Validando Entradas com C#
Challenge: 1 / 2 - Registro de Despesas Válidas
*/

/* 
TODO:
    1. [x] Adicione o valor à lista somente se for maior que zero;
    2. [x] Imprima cada valor da lista de despesas válidas;
*/ 

using System;
using System.Collections.Generic;
using System.Linq;

class WEE25_211 {
    
	static void Main() {
		
		List<int> despesas = new List<int>();

		// Declaração realizadas internamente ao "for": variável temporária
		for (int quantidade = int.Parse(Console.ReadLine()), valor, i = 0; i < quantidade; ++i) {
		    
		    valor = int.Parse( Console.ReadLine() );
		   
		    // 1
		    if (valor > 0) { despesas.Add(valor); }
	    
		}

		string saida = "";
		
		// Mensagem de Suporte para condições que não existem despesas relacionadas.
		if (despesas.Any()) {
		    
		    // 2 
		    foreach (int valor in despesas) { saida += valor.ToString() + "\n"; }
		}
		else { saida = "Sem despesas validas"; }
		
		Console.WriteLine(saida);
	}
}
