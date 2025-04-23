using System;

class Fatorial{
    static void Main() {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        int fatorial = 1;
        int contador = numero;

        while (contador > 1) {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
    }
}
