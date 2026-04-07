Console.WriteLine("Digite a quilometragem inicial do veículo: ");
int kmini = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quilometragem final do veículo: ");
int kmfim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de combustivel consumida: ");
int consumo = Convert.ToInt32(Console.ReadLine());

int consumomed = (kmfim - kmini)/ consumo;

Console.WriteLine("O consumo medio do veículo foi de: " + consumomed + " km/L");
Console.ReadLine();