using System;

class Adivinhacao {
    static void Main() {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        int tentativa = 0;
        int chute = 0;

        Console.WriteLine("Bem-vindo ao Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");
        
        while (chute != numeroSecreto) {
            tentativa++;

            Console.Write("Digite seu palpite: ");
            chute = int.Parse(Console.ReadLine());

            if (chute < numeroSecreto) {
                Console.WriteLine("O número secreto é maior!");
            } else if (chute > numeroSecreto) {
                Console.WriteLine("O número secreto é menor!");
            } else {
                Console.WriteLine("Parabéns! Você acertou!");
            }
        }
        
        Console.WriteLine("Você acertou em " + tentativa + " tentativas!");
    }
}
