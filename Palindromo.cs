using System;

class Palindromo
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine();

        string textoLimpo = LimparTexto(entrada);
        string textoInvertido = InverterTexto(textoLimpo);

        if (textoLimpo == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }

    static string LimparTexto(string texto)
    {
        texto = texto.ToLower(); // tudo minúsculo
        string resultado = "";

        foreach (char c in texto)
        {
            if (char.IsLetterOrDigit(c)) // pega só letras e números
            {
                resultado += c;
            }
        }

        return resultado;
    }

    static string InverterTexto(string texto)
    {
        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        return invertido;
    }
}
