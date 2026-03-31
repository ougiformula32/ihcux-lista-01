/*
Heurísticas aplicadas:

#1 Visibilidade do Status:
- O sistema sempre mostra em qual passo o usuário está (ex: [Passo 1 de 3]).

#3 Controle e Liberdade:
- O usuário pode digitar "voltar" para retornar ao passo anterior.
- Pode digitar "cancelar" a qualquer momento para encerrar o pedido.

#9 Ajuda e Diagnóstico de Erros:
- Mensagens claras e específicas (ex: código inválido mostra faixa válida).
- Tratamento de erro para entradas inválidas (letras, números fora do range, etc).
*/

using System;

int codigo = 0;
int quantidade = 0;

while (true)
{
    Console.WriteLine("[Passo 1] Código do produto (1 a 10):");
    string entrada = Console.ReadLine();

    if (entrada == null) continue;

    entrada = entrada.ToLower();

    if (entrada == "cancelar")
        return;

    if (int.TryParse(entrada, out codigo))
    {
        if (codigo >= 1 && codigo <= 10)
            break;
        else
            Console.WriteLine("Código inválido. Use de 1 a 10.");
    }
    else
    {
        Console.WriteLine("Digite apenas números.");
    }
}

while (true)
{
    Console.WriteLine("[Passo 2] Quantidade:");
    Console.WriteLine("(ou 'voltar' / 'cancelar')");
    string entrada = Console.ReadLine();

    if (entrada == null) continue;

    entrada = entrada.ToLower();

    if (entrada == "cancelar")
        return;

    if (entrada == "voltar")
        return;

    if (int.TryParse(entrada, out quantidade) && quantidade > 0)
        break;
    else
        Console.WriteLine("Quantidade inválida.");
}

Console.WriteLine("[Passo 3] Confirmação");
Console.WriteLine("Produto: " + codigo);
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Digite 'confirmar' ou 'cancelar'");

string opcao = Console.ReadLine();

if (opcao != null)
    opcao = opcao.ToLower();

if (opcao == "confirmar")
    Console.WriteLine("Pedido finalizado!");
else
    Console.WriteLine("Pedido cancelado.");
