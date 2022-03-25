// See https://aka.ms/new-console-template for more information
using FiapHelloWord.Models;

Console.WriteLine("Hello, World!");
HelloModel model = new HelloModel();
Console.Read();
    int valorInt = 100;
    long valorLong = valorInt;
    double valorDouble = valorLong;
valorInt = (int)valorLong;

int soma = 10 + 15 + 3;
int subtracao = soma - 10;
int multiplicacao = soma * subtracao;
double divisao = multiplicacao / subtracao;



    Console.WriteLine("valor inteiro: " + valorInt);
Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtracao: " + subtracao);

int idade = 20;
if (idade > 15 && idade < 18)
{
    Console.WriteLine("sub 17");
}
else if (idade > 17 && idade <= 21) 
{
    Console.WriteLine("Sub 20");
}else{
    Console.WriteLine("nenhuma regra");
}

switch (idade)
{
    case 15:
        Console.WriteLine("15 anos");
        break;
    case 16:
        Console.WriteLine("16 anos");
        break;
    case 17:
        Console.WriteLine("17 anos");
        break;
    case 18:
        Console.WriteLine("18 anos");
        break;
    default:
        Console.WriteLine("Maior");
        break;
        }


