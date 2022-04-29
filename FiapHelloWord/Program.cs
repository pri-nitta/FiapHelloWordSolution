// See https://aka.ms/new-console-template for more information
using FiapHelloWord.Models;

//Console.WriteLine("Hello, World!");
//HelloModel model = new HelloModel();
//Console.Read();
//    int valorInt = 100;
//    long valorLong = valorInt;
//    double valorDouble = valorLong;
//valorInt = (int)valorLong;

//int soma = 10 + 15 + 3;
//int subtracao = soma - 10;
//int multiplicacao = soma * subtracao;
//double divisao = multiplicacao / subtracao;



//    Console.WriteLine("valor inteiro: " + valorInt);
//Console.WriteLine("Soma: " + soma);
//Console.WriteLine("Subtracao: " + subtracao);

//int idade = 20;
//if (idade > 15 && idade < 18)
//{
//    Console.WriteLine("sub 17");
//}
//else if (idade > 17 && idade <= 21) 
//{
//    Console.WriteLine("Sub 20");
//}else{
//    Console.WriteLine("nenhuma regra");
//}

//switch (idade)
//{
//    case 15:
//        Console.WriteLine("15 anos");
//        break;
//    case 16:
//        Console.WriteLine("16 anos");
//        break;
//    case 17:
//        Console.WriteLine("17 anos");
//        break;
//    case 18:
//        Console.WriteLine("18 anos");
//        break;
//    default:
//        Console.WriteLine("Maior");
//        break;
//        }

//for (int i = 0; i <= 100; i++)
//{
//    Console.WriteLine("Valor " + i);
//}
//Console.Read();

//int x = 0;

//while(x < 21)
//{
//    Console.WriteLine(x);
//    x ++;
//}

//int y = 0;
//do
//{
//    Console.Write(y + " ");
//    y ++;
//}while(y < 11);


//string[] lista = { "exatas", "humanas", "biologicas" };

//foreach (var item in lista)
//{
//    Console.Write(item + " ");
//}

//Curso cursoXamarin = new Curso();
//cursoXamarin.CriarCurso("Curso Xamarin", "Rodolfo");
//bool alunoMatriculadoComSucesso = cursoXamarin.MatricularAluno("Paula");

//Curso cursoComInstrutor = new Curso("Curso web", "Doug");

//Curso cursoHardware = new Curso("Equipamentos", 3, 10);

//Curso cursoIonic = new Curso();

//CursoFerias curso = new CursoFerias();

//public class ClasseBase
//{
//    public void Metodo()
//    {
//        Console.WriteLine("Metodo Base");
//    }
//}

//public class Derivada: ClasseBase
//{
//    public void Metodo()
//    {
//        Console.WriteLine("Método derivado");
//    }
//}

try
{

    Curso curso = new Curso();
    string nome = null;
    nome = nome.Substring(0,3);
    curso.CriarAluno(nome);

}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

