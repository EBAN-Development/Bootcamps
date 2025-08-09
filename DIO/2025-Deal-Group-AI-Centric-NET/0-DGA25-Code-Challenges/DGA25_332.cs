/* 
Platform: Digital Innovation One - DIO
BootCamp: Deal Group - AI Centric .NET
Developer: André Bezerra
Collaborator(s): [...]
Module: Aplicando Boas Práticas com C#
Challenge: 2 / 2 - Validando Nomes em camelCase
*/
using System;
using System.Text.RegularExpressions;

class Program {
    
    static void Main() {
        
        // Lê a linha com os nomes das variáveis separados por espaço
        string input = Console.ReadLine();
        string[] variableNames = input.Split(' ');

        // Regex para validar camelCase:
        // Começa com letra minúscula,
        // seguido de letras ou números,
        // palavras internas começam com letra maiúscula sem separadores,
        // sem espaços ou caracteres especiais.
        string camelCasePattern = @"^[a-z]+([A-Z][a-z0-9]+)*$";

        bool allValid = true;

        // Percorre todos os nomes para validar
        foreach (string variable in variableNames) {
            
            // TODO: Verifique se o nome corresponde ao padrão camelCase
            Match match = Regex.Match(variable, camelCasePattern);
            if ( ! match.Success ) {
               allValid = false;
               Console.WriteLine(variable);
            }
            
        }

        // TODO: Caso todos estejam corretos, imprima "All valid"
        if (allValid){
            Console.Write("All valid");
        }
    }
}
