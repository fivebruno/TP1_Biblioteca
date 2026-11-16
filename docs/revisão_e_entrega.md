# TP1 — Revisão Técnica e Consolidação da Entrega

**Projeto:** Sistema de Gestão de Biblioteca Universitária  
**Disciplina:** Projeto de Bloco: Desenvolvimento Back-End  
**Professor:** Orlando Fonseca  
**Aluno:** Bruno César Pimentel Vieira  
**E-mail:** brunoc.vieira@al.infnet.edu.br  
**Trilha de desenvolvimento:** C# / .NET 10  
**Ambiente de trabalho:** Visual Studio Code  
**Versão:** 1.0

---

## 1. Objetivo

Este documento apresenta a revisão técnica e a consolidação dos materiais produzidos no TP1 do Sistema de Gestão de Biblioteca Universitária.

A revisão considera o levantamento dos requisitos, a especificação dos casos de uso, o diagrama UML, a configuração do ambiente de desenvolvimento e o protótipo standalone.

O objetivo é verificar se os artefatos produzidos estão alinhados à especificação do professor e estabelecer uma referência para a evolução do projeto nas entregas seguintes.

## 2. Organização das atividades

O trabalho foi dividido em três etapas:

**Etapa 1 — Engenharia de requisitos e modelagem**

Levantamento das entidades, identificação dos atores, especificação dos requisitos funcionais e não funcionais, documentação das regras de negócio e elaboração dos casos de uso.

**Etapa 2 — Ambiente e protótipo inicial**

Configuração do ambiente de desenvolvimento C#, criação do projeto de console e elaboração de um programa standalone utilizando fundamentos de programação.

**Etapa 3 — Revisão e consolidação**

Verificação da correspondência entre os requisitos, os casos de uso e o protótipo, registro das evidências e organização dos materiais para entrega.

## 3. Rastreabilidade dos requisitos

O protótipo inicial foi delimitado à verificação de determinadas condições necessárias à realização de um empréstimo.

| Requisito | Regra relacionada | Aplicação no protótipo |
|---|---|---|
| RF-007 | RN-003 | Verificação do limite de empréstimos ativos |
| RF-007 | RN-004 | Verificação da disponibilidade do exemplar |
| RF-007 | RN-010 | Verificação das condições de conservação |
| RF-015 | RN-012 | Verificação da validade do cadastro |

O programa utiliza dados informados pelo usuário no console.

Essas verificações representam apenas parte do processo de empréstimo especificado no caso de uso UC-04. O protótipo não registra empréstimos ou modifica os dados do acervo.

Os demais requisitos permanecem documentados para as próximas etapas do desenvolvimento.

## 4. Avaliação do protótipo standalone

### 4.1. Características da implementação

A proposta de implementação utiliza:

- Tipos primitivos, incluindo `int` e `bool`.
- Variáveis do tipo `string` para leitura de respostas.
- Operadores relacionais e lógicos.
- Estruturas condicionais `if/else`.
- Estruturas de repetição `while` e `do/while`.
- Entrada de dados por meio do console.
- Conversão e validação básica de entradas.

O programa foi planejado sem a criação de classes específicas para representar as entidades Livro, Exemplar, Membro, Empréstimo, Reserva e Multa.

### 4.2. Testes funcionais

| Teste | Condição avaliada | Resultado esperado | Resultado obtido |
|---|---|---|---|
| T01 | Nenhum empréstimo ativo; demais condições válidas | Permitido | A preencher |
| T02 | Dois empréstimos ativos; demais condições válidas | Permitido | A preencher |
| T03 | Três empréstimos ativos | Impedido | A preencher |
| T04 | Cadastro inválido | Impedido | A preencher |
| T05 | Exemplar indisponível | Impedido | A preencher |
| T06 | Exemplar danificado | Impedido | A preencher |
| T07 | Quantidade negativa | Solicitar nova entrada | A preencher |
| T08 | Entrada não numérica | Solicitar nova entrada | A preencher |

Os resultados obtidos deverão ser preenchidos após a execução dos testes.

### 4.3. Compilação

**Comando utilizado:**

`dotnet build src/BibliotecaStandaloneTP1`

**Resultado:**

    BibliotecaStandaloneTP1 net10.0 êxito (0,3s) → src\BibliotecaStandaloneTP1\bin\Debug\net10.0\BibliotecaStandaloneTP1.dll'

### 4.4. Execução

**Comando utilizado:**

`dotnet run --project src/BibliotecaStandaloneTP1`

**Resultado:**

    ======================================
    SISTEMA DE BIBLIOTECA UNIVERSITÁRIA
    Verificador de Empréstimos - TP1
    ======================================

    --- NOVA VERIFICAÇÃO ---

## 5. Decisões técnicas

### 5.1. Escolha da linguagem

A trilha selecionada foi C#, utilizando .NET 10, conforme uma das possibilidades apresentadas no enunciado.

A escolha será mantida nas próximas etapas, permitindo a evolução do sistema para uma aplicação orientada a objetos e, posteriormente, para uma API desenvolvida com ASP.NET Core.

### 5.2. Escolha do ambiente de desenvolvimento

O Visual Studio Code foi utilizado como ambiente de edição e organização do projeto, com o .NET SDK responsável pela compilação e execução.

O enunciado estabelece o Visual Studio Community como ambiente da trilha C#. A compatibilidade do projeto com essa IDE deverá ser verificada para atender à orientação formal.

### 5.3. Delimitação da implementação

A implementação inicial foi limitada à verificação das condições necessárias a um empréstimo.

Essa decisão permite demonstrar fundamentos da linguagem sem antecipar a construção das classes de domínio, da camada de persistência ou da API.

## 6. Limitações identificadas

Nesta primeira versão:

- Não há armazenamento permanente de informações.
- O usuário fornece manualmente as condições avaliadas.
- Não há cadastro efetivo de livros, exemplares ou membros.
- Nenhum empréstimo é efetivamente registrado.
- Não são processadas devoluções ou reservas.
- Não existe cálculo monetário de multas.
- Não há autenticação ou autorização implementada.
- Não existe API ou banco de dados.

Essas limitações são compatíveis com o recorte do protótipo inicial e não representam uma implementação completa do sistema especificado.

## 7. Pontos pendentes de validação

Permanecem pendentes as decisões sobre:

- Valor monetário da multa por dia corrido.
- Estados possíveis de conservação dos exemplares.
- Tratamento de reservas concorrentes.
- Regras de cancelamento e expiração de reservas.
- Possibilidade de renovação dos empréstimos.
- Restrições adicionais associadas a multas pendentes.

Esses pontos não serão implementados como regras oficiais sem definição ou validação adicional.

## 8. Uso da inteligência artificial

A inteligência artificial foi utilizada como apoio didático, para explicar conceitos, analisar a estrutura do programa, propor exemplos, auxiliar na revisão do código e melhoria do texto.

## 9. Evolução prevista

Nas próximas etapas, o desenvolvimento será direcionado à implementação progressiva das entidades e das regras de negócio.

Essa evolução deverá contemplar a orientação a objetos, o gerenciamento das operações do sistema, a persistência de dados, a criação da API e a autenticação.

Os requisitos e casos de uso elaborados no TP1 serão utilizados como referência, permitindo verificar se as funcionalidades implementadas permanecem alinhadas às necessidades do sistema.

## 10. Considerações finais

O TP1 estabelece a base documental e técnica do Sistema de Gestão de Biblioteca Universitária.

O levantamento dos requisitos e a especificação dos casos de uso permitem compreender as principais operações do domínio e suas restrições.

O protótipo standalone representa um primeiro contato com a implementação das regras de negócio em C#, utilizando fundamentos de programação.

A conclusão desta entrega depende da revisão dos documentos, da validação do diagrama UML, da compilação e execução do programa e do registro das respectivas evidências.