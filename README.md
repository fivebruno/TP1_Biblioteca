# Sistema de Gestão de Biblioteca Universitária (SGBU)

## Projeto de Bloco — Desenvolvimento Back-End

- **Instituição:** Instituto Infnet
- **Professor:** Orlando Fonseca
- **Aluno:** Bruno César Pimentel Vieira
- **E-mail:** brunoc.vieira@al.infnet.edu.br
- **Entrega:** TP1
- **Linguagem:** C#
- **Framework:** .NET 10

## Sobre o projeto

O projeto tem como objetivo desenvolver um Sistema de Gestão de Biblioteca Universitária que contemple o gerenciamento do acervo bibliográfico, dos membros e das operações de empréstimo, devolução, reserva e cobrança de multas.

O desenvolvimento será realizado progressivamente, começando pelo levantamento dos requisitos e pela implementação de um programa standalone e evoluindo para um sistema com persistência de dados, API e autenticação.

## Conteúdo do TP1

A entrega contempla:

1. Documento de requisitos funcionais e não funcionais.
2. Documentação das regras de negócio.
3. Identificação dos atores.
4. Especificação de três casos de uso.
5. Diagrama UML de casos de uso.
6. Configuração do ambiente C#.
7. Programa standalone inicial.
8. Justificativa do escopo e registro de suposições.

## Tecnologias

- C#
- .NET 10 SDK
- Visual Studio Code
- Visual Studio Community — IDE prevista no enunciado
- Markdown
- PlantUML

## Estrutura

- `docs/requisitos.md` — Engenharia de requisitos e casos de uso.
- `docs/ambiente_e_prototipo.md` — Configuração e documentação do programa.
- `docs/revisao_e_entrega.md` — Revisão técnica e consolidação.
- `docs/diagramas/casos_de_uso.puml` — Diagrama UML editável.
- `src/BibliotecaStandaloneTP1/Program.cs` — Código-fonte do protótipo.

## Como executar

### Pré-requisito

Ter o .NET 10 SDK instalado.

### 1. Abrir o terminal na raiz do projeto

### 2. Verificar o SDK

`dotnet --version`

### 3. Compilar

`dotnet build src/BibliotecaStandaloneTP1`

### 4. Executar

`dotnet run --project src/BibliotecaStandaloneTP1`

## Funcionamento do protótipo

O programa solicita informações sobre a quantidade de empréstimos ativos, a validade do cadastro do membro, a disponibilidade do exemplar e suas condições de conservação.

Em seguida, verifica determinadas regras de negócio para informar se o empréstimo pode ser permitido.

O programa é demonstrativo e não realiza registros permanentes.

## Escopo futuro

Nas próximas etapas serão implementadas as entidades do domínio, as operações completas da biblioteca, os mecanismos de persistência, a API e a autenticação.

## Documentação

Os arquivos Markdown estão disponíveis na pasta `docs`, incluindo a documentação das regras de negócio e os casos de uso que orientarão as próximas implementações.

## Repositório GitHub

O código-fonte, a documentação técnica e o diagrama UML do projeto estão disponíveis no repositório:

[TP1 — Sistema de Gestão de Biblioteca Universitária (SGBU)](https://github.com/fivebruno/TP1_Biblioteca)