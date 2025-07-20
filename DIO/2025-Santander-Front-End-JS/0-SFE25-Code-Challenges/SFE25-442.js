/*
Platform: Digital Innovation One - DIO
BootCamp: Santander 2025 Front-End (JS)
Developer: Monica Cardoso
Collaborator(s): André Bezerra
Module:  Desenvolvendo Soluções com JavaScript
Challenge: 2 / 2 - Contador de Cartas de Duelista
*/

// Lendo a entrada e transformando em um array
let cartas = gets().split(", ").map(c => c.trim());

let contagem = {};

// Contando as ocorrências das cartas
cartas.forEach(
    carta => {
        if (contagem[carta]) {
            contagem[carta]++;
        } 
        else {
            contagem[carta] = 1;
        }
    }
);

// TODO: Agora, ordene as cartas alfabeticamente e exiba a saída no formato "Carta: Quantidade"
let ordenarCartas = Object.keys(contagem).sort()
let catalogo = ordenarCartas.reduce( (carta,quantidade) => { carta[quantidade] = contagem[quantidade]; return carta;}, {} );

let textoformatado

for (let carta in catalogo) { 
    textoformatado = `${carta}: ${catalogo[carta]}`
    console.log(textoformatado);
}
