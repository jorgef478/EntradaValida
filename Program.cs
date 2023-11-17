Console.Clear();

int numero = -1;

Console.WriteLine("~~~~ Entrada Valida ~~~~ ");

while (numero < 0 || numero > 9)
{
Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
numero = Convert.ToInt32(Console.ReadLine());
}

if (numero == 0)
{
    Console.WriteLine("Operação cancelada.");
    Console.WriteLine("Volte Sempre! =)");
}
else
{
    Console.WriteLine($"O número selecionado é: {numero}");
    Console.WriteLine("Volte Sempre! =)");
}