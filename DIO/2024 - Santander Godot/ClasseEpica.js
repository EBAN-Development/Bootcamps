// RECRIANDO FUNÇÃO GETS //

function gets(){
    return "Mago";
}

// COMEÇO DO CÓDIGO //

const classe = gets();

// TODO: Implemente os demais casos para a resolução do desafio
switch(classe) {
  case "Guerreiro":
      print("Você escolheu a classe Guerreiro!");
      break;
  case "Mago":
      print("Você escolheu a classe Mago!");
      break;
  case "Arqueiro":
      print("Você escolheu a classe Arqueiro!");
      break;
  default:
      print("Classe inválida! Escolha entre Guerreiro, Mago ou Arqueiro.");
      break;
}