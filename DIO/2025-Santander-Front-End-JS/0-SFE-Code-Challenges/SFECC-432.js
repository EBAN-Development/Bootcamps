//Aprimorando Habilidades em JavaScript
// 2 / 2 - Dicionário Mágico de Feitiços
// TODO: Implemente um dicionário de feitiços pré-definido, simule um JSON:
const buscarFeitico = {
    "Lumus": "Cria uma luz na ponta da varinha",
    "Expelliarmus": "Desarma o oponente, fazendo com que ele solte o que estiver segurando",
    "Expecto Patronum": "Invoca um Patrono, uma manifestacao magica que afasta Dementadores",
    "Wingardium Leviosa": "Faz objetos levitarem",
    "Alohomora": "Destranca portas e objetos trancados"
}

// TODO: Adicione uma função buscarFeitico, para buscar a descrição de um feitiço e retornar caso não seja encontado:
const feitico = gets().trim(); // Removendo espaços extras

let descricao

if (buscarFeitico[feitico]) {
    descricao = buscarFeitico[feitico] 
}
else { 
    descricao = "Feitico nao encontrado" 
}

print(descricao)