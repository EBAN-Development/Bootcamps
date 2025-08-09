/* 
Platform: Digital Innovation One - DIO
BootCamp: Deal Group - AI Centric .NET
Developer: André Bezerra
Collaborator(s): [...]
Module: Identificando Métodos HTTP e Verificando Endpoints com C#
Challenge: 1 / 2 - Identificando o Método HTTP Mais Frequente
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    
    static void Main() {
       
        // TODO: Preencha Dicionário para mapear métodos válidos e suas descrições
        Dictionary<string, string> methodDescriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"GET", "busca ou recupera dados de um recurso"},
            {"POST", "envia dados para processamento"},
            {"PUT", "atualiza todos os dados de um recurso"},
            {"DELETE", "remove um recurso específico"}
        };

        // Lê a string contendo os métodos HTTP separados por vírgula
        string method, input = Console.ReadLine();
       
        // Divide a entrada em métodos, remove espaços e transforma em maiúsculas
        // Dicionário para contar as ocorrências de cada método (case-insensitive)
        Dictionary<string, int> methodCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (var rawMethod in input.Split(',')) {
            
            method = rawMethod.Trim();

            methodCounts[method] = methodCounts.ContainsKey(method) ? methodCounts[method]+1 : 1;
        }

        // Encontra o método com maior frequência (se houver empate, pega o primeiro)
        int maxCount = methodCounts.Values.Max();
        
        // Caso método inválido
        string answer = "metodo nao reconhecido", mostFrequentMethod = methodCounts.First(kv => kv.Value == maxCount).Key;
        int count = methodCounts[mostFrequentMethod];

        // TODO: Verifique se o método está entre os válidos para definir a descrição
        if ( methodDescriptions.ContainsKey(mostFrequentMethod) ) { answer = methodDescriptions[mostFrequentMethod]; }

        Console.WriteLine($"{mostFrequentMethod} - {answer} - {count}");
    }
}

