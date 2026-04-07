Console.WriteLine("Digite o valor A: ");
double ValA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor B: ");
double ValB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor C: ");
double ValC = Convert.ToDouble(Console.ReadLine());

double SomaAB = ValA + ValB;

if(SomaAB > ValC)
{
    Console.WriteLine("O valor da soma de A + B é maior que C");
}
else
{
    Console.WriteLine("O valor da soma de A + B é menor que C");
}

Console.ReadLine();
