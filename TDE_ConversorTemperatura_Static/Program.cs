using TDE_ConversorTemperatura_Static;

using System;

namespace TDE_ConversorTemperatura_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius =20;
            double fahrenheit = ConversorTemperatura.CelsiusParaFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

            double fOrig = 68;
            double cConvertido = ConversorTemperatura.FahrenheitParaCelsius(fOrig);
            Console.WriteLine($"{fOrig}°F = {cConvertido}°C");

            Console.WriteLine($"Aplicação: {Configuracoes.NomeAplicacao} Versão: {Configuracoes.Versao}");
        }
    }
}
