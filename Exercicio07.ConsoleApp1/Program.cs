Console.WriteLine("Digite o seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double IMC = peso / (altura*altura);

if (IMC < 18.5)
{
    Console.WriteLine("Seu IMC é de: " + IMC + "\n o que é considerado abaixo do peso de acordo com a OMS.");
}
else if (IMC > 18.5 && IMC < 25)
{
    Console.WriteLine("Seu IMC é de: " + IMC + "\n o que é considerado peso normal de acordo com a OMS.");
}
else if (IMC > 25 && IMC < 30)
{
    Console.WriteLine("Seu IMC é de: " + IMC + "\n o que é considerado sobrepeso de acordo com a OMS.");
}
else
{
    Console.WriteLine("Seu IMC é de: " + IMC + "\n o que é considerado obesidade acordo com a OMS.");
}
Console.ReadLine();