/* 
Platform: Digital Innovation One - DIO
BootCamp: Deal Group - AI Centric .NET
Developer: André Bezerra
Collaborator(s): [...]
Module: Manipulando Valores e Trabalhando com Exceções com C#
Challenge: 1 / 2 - Implementando um Sistema de Mensagens para Reservas
 */

/* TODO: 
1 - Lê a entrada como uma string no formato: Nome, Número do Quarto, Número de Diárias
2 - Divide a string pelos separadores de vírgula
3 - Extrai e trata os dados de entrada
4 - A. Calcule o valor total da estadia (R$150 por diária);
    B. Exiba a mensagem formatada conforme solicitado;
*/
using System;

class Program {
    static void Main() {
        
        // 1 e 2  
        string[] parts= Console.ReadLine().Split(',');
        
        // 3 e 4
        Console.WriteLine("{0} vai se hospedar no quarto {1} por R${2:}", 
                            parts[0].Trim(), parts[1].Trim(), int.Parse(parts[2]) * 150);
    }
}
