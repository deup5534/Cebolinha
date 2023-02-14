Console.Clear();


//aviso rápido
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("ATENÇÃO!!");
Console.ResetColor();
Console.WriteLine("Você trocou de corpo com o cebolinha e, está no meio de uma discussão que não é sua.");
Console.WriteLine("\nE agora?");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("pressione uma tecla para continuar...");
Console.ResetColor();
Console.ReadKey();

Console.Clear();

//Mônica
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Mônica:\nCEBOLINHA! POR QUE TEM UM AGIOTA NA MINHA CASA??!");
Console.ResetColor();

//Cebolinha(usuário)
Console.ForegroundColor = ConsoleColor.Green;
string semL;

Console.Write("Escreva o que pensou:\n");
semL = Console.ReadLine()!;

string comL = semL
.Replace("r","l")
.Replace("R","L")
.Replace("R","l")
.Replace("r","L");



Console.Write($"você disse isso:\n{comL}");
Console.WriteLine();
Console.ResetColor();