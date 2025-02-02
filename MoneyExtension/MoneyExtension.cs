using System;

namespace MoneyExtension
{
    public static class Money
    {
        public static int ToCents(this decimal amount)
        {
            if (amount < 0)
                return 0;

            // Converte o valor para uma string com duas casas decimais
            var text = amount.ToString("N2");

            // Remove o separador de milhares e substitui o ponto decimal por nada
            text = text.Replace(",", "").Replace(".", "");

            if (string.IsNullOrEmpty(text))
                return 0;

            // Tenta converter a string para um número inteiro
            if (int.TryParse(text, out var result))
                return result;

            return 0;
        }
    }
}