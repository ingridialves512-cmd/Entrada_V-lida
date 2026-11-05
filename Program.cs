Console.WriteLine("--- Entrada Válida ---\n");

int numeroDigitado = -1;

while (numeroDigitado < 0 || numeroDigitado > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

if (numeroDigitado == 0)
{
    Console.WriteLine("\nvalor inválido.");
}
else
{
    Console.WriteLine($"\nNúmero escolhido = {numeroDigitado}");
}

Console.WriteLine("\nPrograma encerrado. Até a próxima!");          
