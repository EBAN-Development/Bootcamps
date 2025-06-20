/*
Platform: Digital Innovation One - DIO
BootCamp: Santander 2025 Front-End (JS)
Developer: Monica Cardoso
Collaborator(s): André Bezerra
Module: Explorando Lógica de Programação com JavaScript
Challenge: 1 / 2 - Classificação de Personagens
*/

//Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
//- "gets" : lê UMA linha com dado(s) de entrada (inputs) do usuário;
//- "print": imprime um texto de saída (output), pulando linha.

// Lê os valores de entrada e separa corretamente
let valores = gets().split(" ");  
let forca = parseInt(valores[0]); 
let inteligencia = parseInt(valores[1]); 

let classificacao = "";

// TODO: Crie condições if/else para validação da classificação do personagem:
if (forca < 20) {
    if (inteligencia < 15) { 
        classificacao = "Aprendiz"; 
        
    }else { 
        classificacao = "Mago"; 
    }
}
else {    
    if (inteligencia < 15) { 
        classificacao = "Guerreiro"; 
        
    }else { 
        classificacao = "Arquimago";
    }
}
// Exibe o resultado
print(classificacao.trim());
