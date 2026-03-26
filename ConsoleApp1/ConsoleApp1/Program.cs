string teclado;
int soma;


for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número que irei fazer a soma");
    teclado = Console.ReadLine();
    soma = Convert.ToInt32(teclado);
    Console.WriteLine($"A soma total dos números é de {soma + soma}");
}
