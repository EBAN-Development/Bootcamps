/* 
Platform: Digital Innovation One - DIO
BootCamp: WEX - End to End Engineering
Developer: André Bezerra
Collaborator(s): [...]
Module: Filtrando Dados e Validando Entradas com C#
Challenge: 2 / 2 - Seleção de Nomes por Letra
*/

/* 
TODO:
    1. [X] Filtre a lista de nomes que começam com a letra (ignore maiúsculas/minúsculas);
    2. [X] Retorne o resultado e implemente a condição if para retornar 'Nenhum nome encontrado' e exiba o resultado.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class WEE25_212 {
    
	static void Main() {
		
		string linhaDeNomes = Console.ReadLine();

		// Separa os nomes e remove espaços extras
		List<string> nomes = linhaDeNomes
		    .Split(',')
		    .Select(nome => nome.Trim())
		    .ToList();

		string letra_referencia = Console.ReadLine().ToLower();

		// 1
		List<string> filtrados = nomes.Where( nome => nome.ToLower().StartsWith(letra_referencia) ).ToList();
		
		// 2
		if (filtrados.Any()) {
		    foreach (string nome in filtrados) {
			Console.WriteLine(nome);
		    }
		    
		} else{ Console.WriteLine("Nenhum nome encontrado"); }
	}
}
