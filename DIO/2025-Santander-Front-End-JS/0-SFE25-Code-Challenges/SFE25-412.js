/*
Platform: Digital Innovation One - DIO
BootCamp: Santander 2025 Front-End (JS)
Developer: Monica Cardoso
Collaborator(s): André Bezerra
Module: Fundamentos de Estilização com CSS
Challenge: 2 / 2 - Criando Bordas no CSS
*/

// Função responsável por descrever o estilo de borda no CSS
function descreverBorda(estilo) {
    if (estilo === "solid") {
        return "Borda contínua";
    }
    // COMPLETE AQUI: Preencha corretamente cada estilo de borda com sua descrição
    else if (estilo === "dotted") {
        return "Borda pontilhada";
    }
    else if (estilo === "dashed") {
        return "Borda tracejada";
    }
    else if (estilo === "double") {
        return "Borda dupla";
    }
}

// Lê a entrada do usuário
let entrada = gets();

// Imprime a descrição do estilo de borda recebido na "entrada"
print(descreverBorda(entrada));
