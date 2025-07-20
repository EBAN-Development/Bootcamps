/*
Platform: Digital Innovation One - DIO
BootCamp: Santander 2025 Front-End (JS)
Developer: Monica Cardoso
Collaborator(s): André Bezerra
Module:  Desenvolvendo Soluções com JavaScript
Challenge: 1 / 2 - Criador de Nomes de Dragões
*/

// Lê a força do dragão e converte para inteiro
const forca = parseInt(gets().trim());

// Lê o elemento do dragão
const elemento = gets().trim();

// Definição dos prefixos baseados no elemento 
const prefixos = {
    "Fogo": ["Pyro", "Drak"],
    "Gelo": ["Frost", "Glacius"],
    "Raio": ["Volt", "Storm"],
    "Terra": ["Geo", "Titan"]
};

// TODO: Determine o prefixo e sufixo:
let prefixo, sufixo

if (forca < 50) {
    prefixo = prefixos[elemento][0]
    sufixo = "thor"
}
else {
    prefixo = prefixos[elemento][1]
    sufixo = "zar"
}

let nomeDragao = prefixo + sufixo

// TODO: Exiba o nome do dragão
print(nomeDragao)
