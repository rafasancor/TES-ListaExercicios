using System;

class Tabuada{
    static void Main() {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        MostrarTabuada(numero);
    }

    static void MostrarTabuada(int numero) {
        Console.WriteLine("\nTabuada do " + numero + ":");
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}
