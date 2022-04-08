double nota1, nota2, nota3, nota4, media;

Console.WriteLine("-- Média --\n");
Console.WriteLine("Digite as suas notas abaixo.");
Console.WriteLine("Nota 1:");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 2:");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 3:");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 4:");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2+ nota3+ nota4) / 4;

if (nota1 < 0 || nota1 > 10
|| nota2 < 0 || nota2 > 10
|| nota3 < 0 || nota3 > 10
|| nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}
else{
if (media < 5)
{
    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: Reprovado");
}
else
    if (media > 6)
    {
Console.WriteLine($"Você ficou com média {media:N1}. Resultado: Aprovado");
    }
    else{
       Console.WriteLine($"Você ficou com média {media:N1}. Resultado: Você ficou de Recuperação"); 
    }
}
