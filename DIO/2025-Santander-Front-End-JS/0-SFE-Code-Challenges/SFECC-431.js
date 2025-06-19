// Aprimorando Habilidades em JavaScript
// 1 / 2 - Sistema de Estoque da Loja do Mestre dos Magos
// TODO: Implemente aqui uma função verificarEstoque() que recebe três parâmetros;
function verificarEstoque(nomeItem, quantidadeDisponivel, quantidadeSolicitada) {
    // TODO: Retorne conforme a descrição.
    if (isNaN(quantidadeDisponivel) || isNaN(quantidadeSolicitada)) {
        return "Erro: Quantidades devem ser numeros inteiros";
    }
    // TODO: Crie uma condição if/else para verificar a quantidadeSolicitada e a quantidadeDisponivel:
    else if (quantidadeSolicitada > quantidadeDisponivel) {
        return "Estoque insuficiente"
    }
    
    return "Pedido realizado"
}
    
// Lendo as entradas do usuário
let nomeItem = gets();
let quantidadeDisponivel = parseInt(gets());
let quantidadeSolicitada = parseInt(gets());

// TODO: Chame a função e imprima o resultado:
estoque = verificarEstoque(nomeItem, quantidadeDisponivel, quantidadeSolicitada)

print(estoque)