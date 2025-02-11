# DIO - Trilha .NET 

# Sistema-Estacionamento-C#
Nesse projeto eu estou praticando conceitos aprendidos no curso randstad .net da DIO.me

## 📦 Requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (versão X.X.X)
- Git (para clonar o repositório)
- Um editor de código (ex: Visual Studio ou VS Code)

## 🚀 Como Rodar o Projeto

1. **Clone o repositório**:
   ```sh
   git clone https://github.com/chiodis/Sistema-Estacionamento-Csharp.git

2. **Acesse o diretorio**

3. **Restaure as dependencias .NET**
  use o comando: dotnet restore 

4. **Por fim, compile e rode o projeto**
  use o comando: dotnet run


## Desafio de projeto
Para este desafio, o intuito é reforçar conceitos simples de utilização de classes e métodos.

## Contexto
Construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
 Construir uma classe chamada "Estacionamento",

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, foi feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar
