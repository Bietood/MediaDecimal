int quantidade;
decimal nrdigitado;
int contador = 0;
decimal soma = 0;
decimal maior_nr = 999999.99M;
decimal menor_nr = 999999.99M;

Console.Write("Números a serem digitados: ");
quantidade = Convert.ToInt32(Console.ReadLine());

while (contador < quantidade)
{
    contador += 1;
    Console.Write($"{contador}º Número: ");
    nrdigitado = Convert.ToDecimal(Console.ReadLine());
    soma = soma + nrdigitado;

    if (contador == 1)
    {
        maior_nr = nrdigitado;
        menor_nr = nrdigitado;
    }

    if (nrdigitado > maior_nr)
    {
        maior_nr = nrdigitado;
    }

    if (nrdigitado < menor_nr)
    {
        menor_nr = nrdigitado;
    }
}

if (contador > 0)
{
    decimal media = soma / quantidade;

    Console.WriteLine($"Soma: {soma:F2} ");
    Console.WriteLine($"Média: {media:F2} ");
    Console.WriteLine($"Menor: {menor_nr:F2} ");
    Console.WriteLine($"Maior: {maior_nr:F2} ");
}