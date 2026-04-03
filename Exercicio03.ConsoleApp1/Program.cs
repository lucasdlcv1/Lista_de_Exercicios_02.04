Console.WriteLine("Digite a temperatura em graus Celsius: ");
double tempCels= Convert.ToDouble(Console.ReadLine());

double TempFah = (tempCels * 1.8) + 32;

Console.WriteLine($"A temperatura equivalente em Fahrenheit é " + TempFah);
Console.ReadLine();

