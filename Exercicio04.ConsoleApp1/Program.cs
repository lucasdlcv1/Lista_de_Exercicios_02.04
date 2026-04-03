Console.WriteLine("Digite o salario base do funcionário: ");
double SalarioBase = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor total das vendas do funcionário: ");
double TotalVendas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a porcentagem da comissão:");
double Comissao = Convert.ToDouble(Console.ReadLine());

double SalarioTotal = SalarioBase + (TotalVendas*(Comissao/100));

Console.WriteLine("O salario total do funcionario é de: " + SalarioTotal);
Console.ReadLine();