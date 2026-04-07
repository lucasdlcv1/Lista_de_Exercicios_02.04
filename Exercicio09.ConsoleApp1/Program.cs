Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());
int Fatnumero = numero;
Console.Write(numero + "! = ");

for(int i=numero; i > 1; i--)
{
   Fatnumero = Fatnumero * (i-1);
}

for(int i=numero; i >= 2; i--)
{
    Console.Write(numero + " X ");
    numero--;
}

Console.Write("1 = " + Fatnumero);
Console.ReadLine();