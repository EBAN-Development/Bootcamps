/*
Platform: Digital Innovation One - DIO
BootCamp: Santander 2025 Front-End (JS)
Developer: Monica Cardoso
Collaborator(s): André Bezerra
Module: Explorando Lógica de Programação com JavaScript
Challenge: 1 / 2 - Classificação de Personagens
*/

// TODO: Crie dois arrays para armazenar herois e viloes:
let herois = []
let viloes = []
let tipo
let nome

while (true) {
    
    nome = gets()
    
    if (nome === "FIM") { 
        break; 
    }
    
    tipo = gets()
    
    // TODO: Valide se o tipo é "Heroi" ou "Vilao", utilize condições if/else e acrescente o retorno de 'Tipo invalido':
    if (tipo === "Heroi") {
        herois.push(nome)
    }
    
    else if (tipo === "Vilao") {
        viloes.push(nome)
    }
    else {
        print("Tipo invalido")
    }

}

// Exibe os resultados finais
if (herois.length === 0 && viloes.length === 0) {
    print("Nenhum personagem registrado");
} 
else {
    print(`Herois: ${herois.length} - ${herois.join(", ")}`)
    print(`Viloes: ${viloes.length} - ${viloes.join(", ")}`)
}
