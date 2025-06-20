// Fundamentos de Estilização com CSS
// 1 / 2 - Estilizando Texto com CSS

// Função responsável por descrever a propriedade CSS
function descreverPropriedadeCSS(propriedade) {
    if (propriedade === "color") {
        return "Define a cor do texto";
    }
    // COMPLETE AQUI: Preencha corretamente cada propriedade CSS com sua descrição
    else if (propriedade === "font-size") {
        return "Define o tamanho da fonte";
    }
    else if (propriedade === "text-align") {
        return "Alinha o texto na página";
    }
    else if (propriedade ==="font-weight") {
        return "Define o peso da fonte";
    }
}

// Lê a entrada do usuário
let entrada = gets();

// Imprime a descrição da propriedade CSS recebida na "entrada"
print(descreverPropriedadeCSS(entrada));