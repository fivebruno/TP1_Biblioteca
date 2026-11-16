
Console.WriteLine("======================================");
Console.WriteLine(" SISTEMA DE BIBLIOTECA UNIVERSITÁRIA");
Console.WriteLine(" Verificador de Empréstimos - TP1");
Console.WriteLine("======================================");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- NOVA VERIFICAÇÃO ---");

    int emprestimosAtivos;
    bool entradaValida;

    do
    {
        Console.Write("Quantidade de empréstimos ativos: ");

        entradaValida = int.TryParse(
            Console.ReadLine(),
            out emprestimosAtivos
        ) && emprestimosAtivos >= 0;

        if (!entradaValida)
        {
            Console.WriteLine(
                "Erro: informe um número inteiro não negativo."
            );
        }

    } while (!entradaValida);

    string respostaCadastro;

    do
    {
        Console.Write("O membro possui cadastro válido? (S/N): ");

        respostaCadastro = (
            Console.ReadLine() ?? ""
        ).Trim().ToUpperInvariant();

    } while (respostaCadastro != "S" && respostaCadastro != "N");

    bool cadastroValido = respostaCadastro == "S";

    string respostaDisponibilidade;

    do
    {
        Console.Write("O exemplar está disponível? (S/N): ");

        respostaDisponibilidade = (
            Console.ReadLine() ?? ""
        ).Trim().ToUpperInvariant();

    } while (
        respostaDisponibilidade != "S" &&
        respostaDisponibilidade != "N"
    );

    bool exemplarDisponivel = respostaDisponibilidade == "S";

    string respostaConservacao;

    do
    {
        Console.Write("O exemplar está em bom estado? (S/N): ");

        respostaConservacao = (
            Console.ReadLine() ?? ""
        ).Trim().ToUpperInvariant();

    } while (
        respostaConservacao != "S" &&
        respostaConservacao != "N"
    );

    bool exemplarEmBomEstado = respostaConservacao == "S";

    const int limiteEmprestimos = 3;

    Console.WriteLine("\n--- RESULTADO ---");

    if (!cadastroValido)
    {
        Console.WriteLine(
            "Empréstimo impedido: cadastro inválido."
        );
    }
    else if (emprestimosAtivos >= limiteEmprestimos)
    {
        Console.WriteLine(
            "Empréstimo impedido: limite de empréstimos atingido."
        );
    }
    else if (!exemplarDisponivel)
    {
        Console.WriteLine(
            "Empréstimo impedido: exemplar indisponível."
        );
    }
    else if (!exemplarEmBomEstado)
    {
        Console.WriteLine(
            "Empréstimo impedido: exemplar em condição inadequada."
        );
    }
    else
    {
        Console.WriteLine(
            "Empréstimo permitido pelas condições verificadas."
        );
    }

    string respostaContinuar;

    do
    {
        Console.Write("\nDeseja realizar outra verificação? (S/N): ");

        respostaContinuar = (
            Console.ReadLine() ?? ""
        ).Trim().ToUpperInvariant();

    } while (
        respostaContinuar != "S" &&
        respostaContinuar != "N"
    );

    continuar = respostaContinuar == "S";
}

Console.WriteLine("\nPrograma encerrado.");
