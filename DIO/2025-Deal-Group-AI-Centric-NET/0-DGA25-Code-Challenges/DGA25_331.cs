/* 
Platform: Digital Innovation One - DIO
BootCamp: Deal Group - AI Centric .NET
Developer: André Bezerra
Collaborator(s): [...]
Module: Aplicando Boas Práticas com C#
Challenge: 1 / 2 - Aplicando Boas Práticas no Uso de Verbos RESTful
*/

using System;
using System.Collections.Generic;

class Program {
    // Método estático que pluraliza a palavra conforme regras básicas do inglês
    static string Pluralize(string word) {
        // Se a palavra termina em 'y' precedida de consoante, troca por 'ies'
        if (word.EndsWith("y") && word.Length > 1 && "aeiou".IndexOf(word[word.Length - 2]) == -1) {
            return word.Substring(0, word.Length - 1) + "ies";
        }
        // Se termina em s, x, z, ch ou sh, adiciona 'es'
        else if (word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh")) {
            return word + "es";
        }
        else {
            // Para os demais casos, adiciona 's'
            return word + "s";
        }
    }   
    
    static void Main() {
        
        // TODO: Preencha o dicionário que mapeia as ações para os verbos HTTP correspondentes
        Dictionary<string, string> httpVerbs = new Dictionary<string, string>()
        {
            { "list", "GET" },
            { "create", "POST" },
            { "update", "PUT" },
            { "delete", "DELETE" }
        };

        // Lê a entrada do usuário no formato "ação recurso" (ex: "list user")
        string input = Console.ReadLine();

        // Divide a entrada em duas partes: ação e recurso
        string[] parts = input.Split(' ');
        string action = parts[0].ToLower();
        string resource = parts[1].ToLower();

        // Obtém o verbo HTTP correspondente à ação fornecida
        string verb = httpVerbs[action];
        
        // TODO: Defina o endpoint conforme a ação
        string endpoint;
        
        endpoint = (action == "list" || action == "create") ? $"/{Pluralize(resource)}" : $"/{resource}/" + "{id}";

        // Imprime o verbo HTTP e o endpoint no formato especificado
        Console.WriteLine(verb);
        Console.WriteLine(endpoint);
    }
}
