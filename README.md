# Microondas Digital

Aplicação desktop desenvolvida em .NET para simular o funcionamento de um micro-ondas digital, permitindo aquecimento manual, programas pré-definidos e cadastro de programas personalizados utilizando conceitos de orientação a objetos.

## Nível atendido

✅ Nível 3 - Cadastro de programas de aquecimento customizados

## Tecnologias utilizadas

- C#
- .NET Framework 4.8
- Windows Forms
- Newtonsoft.Json
- JSON para persistência de dados

## Funcionalidades

### Nível 1
- Aquecimento manual configurável
- Controle de tempo e potência
- Início rápido (30 segundos)
- Acréscimo de 30 segundos durante aquecimento
- Pausa e cancelamento
- Exibição do processo de aquecimento

### Nível 2
- Programas pré-definidos:
  - Pipoca
  - Leite
  - Carnes
  - Frango
  - Feijão
- Bloqueio de alteração dos programas padrão
- Strings de aquecimento personalizadas

### Nível 3
- Cadastro de programas personalizados
- Validação de caracteres
- Persistência em arquivo JSON
- Diferenciação visual dos programas personalizados

## Estrutura do projeto

- Entities: classes de domínio
- Services: regras de negócio
- Forms: interface gráfica
- Exceptions: regras de negócio

## Como executar

1. Clone o repositório

2. Abra o projeto no Visual Studio

3. Restaure os pacotes NuGet

4. Execute o projeto utilizando o Visual Studio

## Persistência

Os programas personalizados são armazenados no arquivo:

Dados/programas.json

## Challenge

This is a challenge by [Coodesh](https://coodesh.com/)