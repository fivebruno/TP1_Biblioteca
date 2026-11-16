# TP1 - Ambiente de Desenvolvimento e Protótipo Standalone

## 1. Introdução

Esta etapa contempla a configuração do ambiente de desenvolvimento e a criação de um programa standalone inicial para o Sistema de Gestão de Biblioteca Universitária (SGBU).

O protótipo foi planejado para demonstrar fundamentos da linguagem C#, incluindo tipos de dados, operadores, estruturas condicionais e estruturas de repetição.

A implementação não contempla ainda a modelagem orientada a objetos das entidades do sistema.

## 2. Ambiente de desenvolvimento

**Linguagem**: C#

**Framework**: .NET 10

**Editor de desenvolvimento**: Visual Code Studio

**Extensão**: C# Dev Kit

**Tipo de aplicação**: Console (standalone)

**Nome do projeto**: BibliotecaStandaloneTP1

### 2.1. Verificação do ambiente

Comando utilizado para consultar a versão do SDK:

    dotnet --version

Versão encontrada:

    10.0.404

### 2.2. Criação do projeto

Comando utilizado:

    dotnet new console -n BibliotecaStandaloneTP1 -f net10.0 -o src/BibliotecaStandaloneTP1

### 2.3. Compilação e execução

Comandos utilizados:

    dotnet build src/BibliotecaStandaloneTP1

    dotnet run --project src/BibliotecaStandaloneTP1

Resultado da compilação:

    "BibliotecaStandaloneTP1 net10.0 êxito (0,3s) → src\BibliotecaStandaloneTP1\bin\Debug\net10.0\BibliotecaStandaloneTP1.dll"

    "======================================
    SISTEMA DE BIBLIOTECA UNIVERSITÁRIA
    Verificador de Empréstimos - TP1
    ======================================

    --- NOVA VERIFICAÇÃO ---
    Quantidade de empréstimos ativos: "

## 3. Descrição do protótipo

O programa desenvolvido realiza uma verificação inicial das condições necessárias para autorizar o empréstimo de um exemplar.

São informados:

- Quantidade de empréstimos ativos do membro;
- Validade do cadastro do membro;
- Disponibilidade do exemplar;
- Condição de conservação do exemplar.

Após receber os dados, o programa avalia as condições e apresenta uma mensagem indicando se o empréstimo é permitido ou impedido.

O programa não registra empréstimos reais. Sua finalidade é demonstrar a aplicação inicial das regras de negócio.

## 4. Fundamentos de programação utilizados

### 4.1. Tipos de dados

- int: Representa a quantidade de empréstimos ativos;
- bool: Representa as condições de validade do cadastro, disponibilidade e conservação do exemplar;
- string: Armazena as respostas fornecidas pelo usuário.

### 4.2. Operadores

- ">=: Verifica se a quantidade de empréstimos atingiu o limite;
- ==: Compara valores informados pelo usuário;
- &&: Combina condições lógicas;
- !: Representa a negação de uma condição booleana.

### 4.3. Estruturas de controle

- if/else: Permite selecionar o resultado conforme as condições verificadas; 
- while: Permite repetir a verificação de empréstimos;
- do/while: Permite repetir perguntas quando as informações fornecidas não correspondem aos valores esperados.

### 4.4. Validação de dados

O método int.TryParse é utilizado para verificar se quantidade de empréstimos informada corresponde a um número inteiro válido.

O programa também rejeita quantidades negativas e solicita respostas S ou N para as perguntas relacionadas às condições.

## 5. Regras de negócio representadas

- RN-003: Um membro pode possuir até três empréstimos ativos;
- RN-004: O exemplar precisa estar disponível e adequado para uso;
- RN-010: Exemplares danificados ou indisponíveis não podem ser emprestados;
- RN-012: O membro precisa possuir cadastro válido.

Essas regras são verificadas a partir de informações fornecidas
manualmente durante a execução.

## 6. Testes realizados

| Teste | Situação | Resultado esperado | Resultado obtido |
|---|---|---|---|
| T01 | Nenhum empréstimo ativo, condições válidas | Permitido | Pendente |
| T02 | Dois empréstimos ativos, condições válidas | Permitido | Pendente |
| T03 | Três empréstimos ativos | Impedido | Pendente |
| T04 | Cadastro inválido | Impedido | Pendente |
| T05 | Exemplar indisponível | Impedido | Pendente |
| T06 | Exemplar danificado | Impedido | Pendente |
| T07 | Quantidade negativa | Solicitar nova entrada | Pendente |
| T08 | Entrada não numérica | Solicitar nova entrada | Pendente |

Os resultados obtidos deverão ser preenchidos após a execução
dos testes no ambiente de desenvolvimento.

## 7. Uso de IA como apoio ao desenvolvimento

A inteligência artificial foi utilizada como apoio didático, para explicar conceitos, analisar a estrutura do programa, propor exemplos, auxiliar na revisão do código e melhoria do texto.

## 8. Limitações do protótipo

O programa não possui:

- Cadastro persistente de membros;
- Registro efetivo de empréstimos;
- Controle automatizado dos exemplares;
- Cálculo de prazos e multas;
- Gerenciamento de reservas;
- Banco de dados;
- API REST;
- Autenticação.

Essas funcionalidades serão desenvolvidas nas estapas posteriores do Projeto de Bloco.

## 9. Conclusão

A implementação inicial tem como objetivo aplicar fundamentos da linguagem C# a uma regra do domínio da biblioteca.

A conclusão desta etapa depende da compilação e execução do programa e da verificação de seus resultados.

O protótipo servirá de referência para a evolução do sistema, sem substituir os modelos orientados a objetos e a arquitetura que serão implementados nas próximas entregas.