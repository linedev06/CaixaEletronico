decimal restante, valorSaque; 
int notas200, notas100, notas50, notas20, notas10, notas5, notas2, notas1;

Console.WriteLine("--- Caixa Eletrônico ---\n");

Console.Write("Digite o valor a ser sacado: ");
valorSaque = Convert.ToInt32(Console.ReadLine());

if ( valorSaque <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Valor de saque invalido");
    Console.ResetColor();
}

if (valorSaque % 1 > 0)
{
    Console.WriteLine("\nEste caixa não trabalha com moedas.");
    return;
}

restante = valorSaque;

 notas200 = (int)(restante / 200);
 restante = restante % 200;

 notas100 = (int)(restante / 100);
 restante = restante % 100;

 notas50 = (int)(restante / 50);
 restante = restante % 50;

 notas20 = (int)(restante /20);
 restante = restante % 20;

 notas10 = (int)(restante / 10);
 restante = restante % 10;

 notas5 = (int)(restante / 5);
 restante = restante % 5;

notas2 = (int)(restante / 2);
restante = restante % 2;

 notas1 = (int)(restante / 1);
 restante = restante % 1;

 Console.WriteLine($"O caixa deve entregar: ");


 if (notas200 >= 1 ) 
 {
 Console.Write($"{notas200} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
 Console.WriteLine("200,00");
 Console.ResetColor();
 }

if (notas100 >= 1) 
{
Console.Write($"{notas100} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("100,00");
Console.ResetColor();
}

if (notas50 >= 1) 
{
Console.Write($"{notas50} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("50,00");
Console.ResetColor();
}

if (notas20 >= 1) 
{
Console.Write($"{notas20} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("20,00");
Console.ResetColor();
}

if (notas10 >= 1) 
{
Console.Write($"{notas10} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("10,00");
Console.ResetColor();
}

if (notas5 >= 1 ) 
{
Console.Write($"{notas5} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("5,00");
Console.ResetColor();
}

if (notas2 >= 1) 
{
Console.Write($"{notas2} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("2,00");
Console.ResetColor();
}

if (notas1 >= 1) 
{
Console.Write($"{notas1} nota(s) de R$");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("1,00");
Console.ResetColor();
}
