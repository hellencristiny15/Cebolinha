// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fale para o cebolinha falar :");
string fala = Console.ReadLine();
string falaCebolinha = fala.Replace("r", "l").Replace("R", "L");
Console.WriteLine(falaCebolinha);
