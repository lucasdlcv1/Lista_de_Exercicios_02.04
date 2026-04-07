Console.WriteLine("Digite a nota da primeira nota do aluno: ");
double Nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota da segunda nota do aluno: ");
double Nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota do aluno: ");
double PNota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda nota do aluno: ");
double PNota2 = Convert.ToDouble(Console.ReadLine());

double MediaPond = ((Nota1 * PNota1) + (Nota1 * PNota2)) / (PNota1 + PNota2);

Console.WriteLine("A média ponderada do aluno foi de: " + MediaPond);

Console.ReadLine();