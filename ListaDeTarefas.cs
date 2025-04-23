using System;
using System.Collections.Generic;

class ListaDeTarefas {
    static void Main() {
        List<string> tarefas = new List<string>();
        List<bool> concluida = new List<bool>(); // Lista para armazenar o status de conclusão de cada tarefa
        string tarefa;
        int opcao;

        do {
            Console.WriteLine("\n--- Lista de Tarefas ---");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("3 - Mostrar todas as tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    // Adicionar tarefa
                    Console.Write("Digite a tarefa: ");
                    tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    concluida.Add(false); // Ao adicionar, a tarefa começa como não concluída
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                    break;

                case 2:
                    // Marcar tarefa como concluída
                    Console.WriteLine("\nTarefas pendentes:");
                    for (int i = 0; i < tarefas.Count; i++) {
                        if (!concluida[i]) {
                            Console.WriteLine((i + 1) + " - " + tarefas[i]);
                        }
                    }

                    Console.Write("Escolha a tarefa para marcar como concluída: ");
                    int indice = int.Parse(Console.ReadLine()) - 1;

                    if (indice >= 0 && indice < tarefas.Count && !concluida[indice]) {
                        concluida[indice] = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    } else {
                        Console.WriteLine("Tarefa inválida ou já concluída!");
                    }
                    break;

                case 3:
                    // Mostrar todas as tarefas
                    Console.WriteLine("\n--- Todas as Tarefas ---");
                    for (int i = 0; i < tarefas.Count; i++) {
                        string status = concluida[i] ? "(Concluída)" : "(Pendente)";
                        Console.WriteLine((i + 1) + " - " + tarefas[i] + " " + status);
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 4);
    }
}
