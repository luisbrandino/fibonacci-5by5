/*
1 - Faça um programa que leia um numero inteiro e imprima até esta posicao da sequencia fibonacci
*/

Console.Write("Digite um número: ");
int number = int.Parse(Console.ReadLine());

while (number <= 0)
{
    Console.Write("Número não pode ser negativo ou zero. Tente novamente: ");
    number = int.Parse(Console.ReadLine());
}

int last = 0;
int current = 1;
for (int i = 0; i < number; i++)
{
    Console.Write($"{current} ");

    int aux = last + current;
    last = current;
    current = aux;
}