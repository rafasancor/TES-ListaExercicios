using System;

class CalculoImc{
    static void Main() {
    
        Console.Write("Digite o seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a sua altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("\nSeu IMC é: " + imc.ToString("F2"));

        if (imc < 18.5) {
            Console.WriteLine("Classificação: Abaixo do peso");
        } else if (imc >= 18.5 && imc <= 24.9) {
            Console.WriteLine("Classificação: Peso normal");
        } else if (imc >= 25 && imc <= 29.9) {
            Console.WriteLine("Classificação: Sobrepeso");
        } else {
            Console.WriteLine("Classificação: Obesidade");
        }
    }
}
