using System;

class ValidadorDeSenha {
    static void Main() {
        Console.WriteLine("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool temMinimo = senha.Length >= 8;
        bool temMaiuscula = false;
        bool temNumero = false;
        bool temEspecial = false;

        foreach (char c in senha) {
            if (char.IsUpper(c)) temMaiuscula = true;
            else if (char.IsDigit(c)) temNumero = true;
            else if (!char.IsLetterOrDigit(c)) temEspecial = true;
        }

        if (temMinimo && temMaiuscula && temNumero && temEspecial) {
            Console.WriteLine("Senha forte!");
        } else {
            Console.WriteLine("Senha fraca. Ela deve ter pelo menos:");
            if (!temMinimo) Console.WriteLine("- 8 caracteres");
            if (!temMaiuscula) Console.WriteLine("- 1 letra maiúscula");
            if (!temNumero) Console.WriteLine("- 1 número");
            if (!temEspecial) Console.WriteLine("- 1 caractere especial (ex: !, @, #)");
        }
    }
}
