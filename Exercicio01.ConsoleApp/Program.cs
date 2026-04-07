
Console.WriteLine("Digite a unidade de medida:");
Console.WriteLine("m (metros)\ncm (centimetros) \nmm (milimetros)");
string UM = Console.ReadLine();
Console.Write("\nDigite a largura da caixa: ");
double L = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o comprimento da caixa: ");
double C = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a altura da caixa: ");
double H = Convert.ToDouble(Console.ReadLine());

double Vol = L * C * H;

Console.WriteLine($"\nO Volume da caixa é {Vol}{UM}³");
Console.ReadLine();