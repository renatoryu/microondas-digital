# Microondas Digital

Aplicação desktop desenvolvida em C# .NET Framework para simular o funcionamento de um micro-ondas digital, permitindo aquecimento manual, utilização de programas pré-definidos e cadastro de programas personalizados utilizando conceitos de orientação a objetos.

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
- Início rápido (30 segundos com potência 10)
- Acréscimo de 30 segundos durante aquecimento
- Pausa e cancelamento do aquecimento
- Exibição dinâmica do processo de aquecimento

### Nível 2
- Programas de aquecimento pré-definidos:
  - Pipoca
  - Leite
  - Carnes de boi
  - Frango
  - Feijão
- Programas padrão protegidos contra alteração e exclusão
- Cada programa possui seu próprio caractere de aquecimento
- Bloqueio de alteração de tempo e potência ao selecionar programas

### Nível 3
- Cadastro de programas de aquecimento personalizados
- Validação de caractere de aquecimento duplicado
- Bloqueio do caractere padrão "."
- Persistência dos programas utilizando arquivo JSON
- Diferenciação visual dos programas personalizados no ComboBox

## Estrutura do projeto

```

MicroondasDigital
│
├── Entities       → Classes de domínio
├── Services       → Regras de negócio e persistência
├── Forms          → Interface gráfica Windows Forms
├── Exceptions     → Exceções específicas da aplicação
├── Enums          → Enumerações utilizadas pelo sistema
└── Dados          → Arquivo JSON para armazenamento

```

## Requisitos

- Visual Studio 2022 ou superior
- .NET Framework 4.8
- Sistema operacional Windows

## Como executar

1. Clone o repositório
2. Abra o arquivo `.sln` no Visual Studio
3. Restaure os pacotes NuGet
4. Execute o projeto utilizando o Visual Studio

## Persistência

Os programas personalizados são armazenados no arquivo:

```

Dados/programas.json

```

## Challenge

This is a challenge by [Coodesh](https://coodesh.com/)
```
