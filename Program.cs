﻿ decimal restante, valorSaque;

int notas200, notas100, notas50, notas20, notas10, notas5, notas2, notas1, corDefinida;

string saque;

       Console.WriteLine("╔═════════════════════════════╗");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║   ╔═════════════════════╗   ║");
       Console.WriteLine("║   ║                     ║   ║");
        Console.WriteLine("      Escolha um banco:");
       DefinirCor(ConsoleColor.Red);

       Console.WriteLine("      B - Bradesco    ");

        DefinirCor(ConsoleColor.DarkRed);

       Console.WriteLine("      S - Santander    ");

         DefinirCor(ConsoleColor.Blue);

       Console.WriteLine("      C - Caixa Econômica");
       Console.ResetColor();
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ╚═════════════════════╝   ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║ ___________________________ ║");
Console.WriteLine("║  _________________________  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  1  |  2  |  3  |  4  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  5  |  6  |  7  |  8  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  #  |  9  |  0  |  *  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║ ___________________________ ║");;
   Console.WriteLine("║                             ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║  ╔═══════════════════════╗  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ╚═══════════════════════╝  ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("╚═════════════════════════════╝");

      






       char letraBanco = Console.ReadKey().KeyChar;

       Console.WriteLine();




       string bancoEscolhido;




       switch (Char.ToUpper(letraBanco))

       {

           case 'B':

               bancoEscolhido = "Bradesco";

               corDefinida = 1;

               break;

           case 'S':

               bancoEscolhido = "Santander";

               corDefinida = 2;

               break;

           case 'C':

               bancoEscolhido = "Caixa Econômica";

               corDefinida = 3;

               break;

           default:

               bancoEscolhido = "Banco desconhecido";

               corDefinida = 4;

               break;

       }


Console.WriteLine("╔═════════════════════════════╗");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║   ╔═════════════════════╗   ║");
       Console.WriteLine("║   ║                     ║   ║");

       Console.WriteLine();

       Console.ForegroundColor = ConsoleColor.White;

       Console.WriteLine($"      Banco escolido: ");

       

       switch (corDefinida)

       {

           case 1:

               DefinirCor(ConsoleColor.Red);

               break;

           case 2:

                DefinirCor(ConsoleColor.DarkRed);

               break;

           case 3:

                DefinirCor(ConsoleColor.Blue);

               break;

           default:

                DefinirCor(ConsoleColor.DarkGray);

               break;

       }

        Console.WriteLine($"      {bancoEscolhido}.");

       Console.ResetColor();

 Console.ResetColor();
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ╚═════════════════════╝   ║");
       Console.WriteLine("║                             ║");
      Console.WriteLine("║ ___________________________ ║");
Console.WriteLine("║  _________________________  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  1  |  2  |  3  |  4  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  5  |  6  |  7  |  8  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  #  |  9  |  0  |  *  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║ ___________________________ ║");
   Console.WriteLine("║                             ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║  ╔═══════════════════════╗  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ╚═══════════════════════╝  ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("╚═════════════════════════════╝");



Thread.Sleep(2000);



Console.WriteLine("╔═════════════════════════════╗");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║   ╔═════════════════════╗   ║");
       Console.WriteLine("║   ║                     ║   ║");

Console.WriteLine("║   ║                     ║   ║");
 Console.WriteLine("      O que você gostaria?");
 Console.WriteLine("      S - Saque");

 Console.WriteLine("      D - Depósito");
Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ╚═════════════════════╝   ║");
       Console.WriteLine("║                             ║");
      Console.WriteLine("║ ___________________________ ║");
Console.WriteLine("║  _________________________  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  1  |  2  |  3  |  4  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  5  |  6  |  7  |  8  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  #  |  9  |  0  |  *  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║ ___________________________ ║");
      Console.WriteLine("║                             ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║  ╔═══════════════════════╗  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ╚═══════════════════════╝  ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("╚═════════════════════════════╝");
 saque = Console.ReadLine()!;

if (saque == "s")
{
Thread.Sleep(2000);
Console.WriteLine("╔═════════════════════════════╗");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║   ╔═════════════════════╗   ║");
       Console.WriteLine("║   ║                     ║   ║");

Console.WriteLine("║   ║                     ║   ║");

Console.WriteLine("       Digite o valor  ");
Console.WriteLine("       Para sacar: ");
Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ╚═════════════════════╝   ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║ ___________________________ ║");
Console.WriteLine("║  _________________________  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  1  |  2  |  3  |  4  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  5  |  6  |  7  |  8  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  #  |  9  |  0  |  *  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║ ___________________________ ║");
        Console.WriteLine("║                             ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║  ╔═══════════════════════╗  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ╚═══════════════════════╝  ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("╚═════════════════════════════╝");

valorSaque = Convert.ToInt32(Console.ReadLine());


if ( valorSaque <= 0 || valorSaque > 2000)

{

    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("\nValor de saque invalido, limite maximo 2000 reais ");

    Console.ResetColor();

    return;

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

Console.WriteLine("╔═════════════════════════════╗");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║   ╔═════════════════════╗   ║");
       Console.WriteLine("║   ║                     ║   ║");

Console.WriteLine("║   ║                     ║   ║");

Console.WriteLine($"     O caixa deve entregar: ");



if (notas200 > 0) Console.WriteLine($"     {notas200} nota(s) de R$200,00");

if (notas100 > 0) Console.WriteLine($"     {notas100} nota(s) de R$100,00");

if (notas50 > 0) Console.WriteLine($"     {notas50} nota(s) de R$50,00");

if (notas20 > 0) Console.WriteLine($"     {notas20} nota(s) de R$20,00");

if (notas10 > 0) Console.WriteLine($"     {notas10} nota(s) de R$10,00");

if (notas5 > 0) Console.WriteLine($"     {notas5} nota(s) de R$5,00");

if (notas2 > 0) Console.WriteLine($"     {notas2} nota(s) de R$2,00");

if (notas1 > 0) Console.WriteLine($"     {notas1} nota(s) de R$1,00");
Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ║                     ║   ║");
       Console.WriteLine("║   ╚═════════════════════╝   ║");
       Console.WriteLine("║                             ║");
      Console.WriteLine("║ ___________________________ ║");
Console.WriteLine("║  _________________________  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  1  |  2  |  3  |  4  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  5  |  6  |  7  |  8  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║  |     |     |     |     |  ║");
Console.WriteLine("║  |  #  |  9  |  0  |  *  |  ║");
Console.WriteLine("║  |_____|_____|_____|_____|  ║");
Console.WriteLine("║ ___________________________ ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("║  ╔═══════════════════════╗  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ║                       ║  ║");
       Console.WriteLine("║  ╚═══════════════════════╝  ║");
       Console.WriteLine("║                             ║");
       Console.WriteLine("╚═════════════════════════════╝");
}

else if (saque == "d")

{

    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Caixa eletronico com problemas para depósito, pedimos desculpa pela incoveniência");

    Console.ResetColor();

}

else

{

    Environment.Exit(-1);

}


void DefinirCor(ConsoleColor cor)

{

    Console.ForegroundColor = cor;

}