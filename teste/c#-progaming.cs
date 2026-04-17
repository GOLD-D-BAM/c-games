// lost musics

//C# It is a type of language that has a lot of typing.//
//name of the variable//
//↓//
using System.Threading;

string MensagemDeBoasVindas = "bem vindo a lost musics, aqui você pode encontrar as melhores músicas para ouvir e se divertir!";    

      //name of the variable,always start with a capital letter //
            //↓ pascal case//
void ExibirLogo()
//⬆//
//name of the function, void never returns anything//
{

          //displays the literal string//the @ before the string allows to write the string in multiple lines without the need of using \n for new lines.//
                //⬇ called of verbatim literal//
Console.WriteLine(@"
█░░ █▀█ █▀ ▀█▀   █▀▄▀█ █░█ █▀ █ █▀▀ █▀
█▄▄ █▄█ ▄█ ░█░   █░▀░█ █▄█ ▄█ █ █▄▄ ▄█");
Console.WriteLine("\n");
Console.WriteLine(MensagemDeBoasVindas);



}
//everything {} is the body of the function, where the code that will be executed when the function is called resides.//
void Main()
{
      ExibirLogo();
         // /N is used to create a new line in the console output.//
                  //⬇//
Console.WriteLine("\ndigite 1 para registrar uma banda,");
Console.WriteLine("digite 2 para mostrar as bandas");
Console.WriteLine("digite 3 para exibir a media de uma banda ");
Console.WriteLine("digite 4  para avaliar a banda");
Console.WriteLine("digite 5 para sair do programa");
       //write, is used to display the text without a new line at the end, so the cursor will stay on the same line after displaying the text.//
Console.Write("\ndigite a opção desejada: ");
      //cnsole.ReadLine() is used to read the input from the user, it will wait until the user types something and presses enter.//

      // the "!" after ReadLine() is used to indicate that the value returned by ReadLine() will not be null, it is a way to tell the compiler that we are sure that the user will enter something and it will not be null.//
 // string: tipo de dado usado para armazenar textos (sequência de caracteres).
string opcao = Console.ReadLine()!;
//int is a data type that represents an integer number, it can store whole numbers without decimal points.//
//parse is a method that converts a string to a specific data type, in this case, it converts the string input from the user to an integer.//
int opcaonumerica = int.Parse(opcao);
// IF is a conditional statement that allows to execute a block of code only if a certain condition is true.//
if (opcaonumerica == 1)
{
    Console.WriteLine("voce digitou a opção " + opcao);
   
}
// The switch statement checks a value and compares it to several cases.
// When it finds a matching case, it executes that block.
// The break statement interrupts execution.
// The default statement runs if no value matches.//
//⬇//
switch (opcaonumerica)
// O tipo usado no switch deve ser o mesmo dos cases.
// Se for string → usar "1"
// Se for int → usar 1 (sem aspas)
{
      // case: define uma condição específica dentro do switch; executa se o valor for igual./
    case 1: 
       registrarBanda();
       // break: interrupts the execution of the switch after a case, preventing it from continuing with subsequent cases.//
        break;
    case 2:
        Console.WriteLine("você escolheu mostrar as bandas");
        break;
    case 3:
        Console.WriteLine("você escolheu exibir a media de uma banda");
        break;
    case 4:
        Console.WriteLine("você escolheu avaliar a banda");
        break;
    case 5:
        Console.WriteLine("você escolheu sair do programa");
        break;
      
    default:
    // default: executa quando nenhum case corresponde ao valor do switch.
        Console.WriteLine("opção inválida, por favor digite uma opção válida.");
        break;
}

}

void registrarBanda()
{
      // Console.Clear(): limpa todo o conteúdo exibido no console.
Console.Clear();
Console.WriteLine("registrar banda");
Console.Write("digite o nome da banda: ");
string nomedaBanda = Console.ReadLine()!;
                        // +: usado para somar números ou concatenar (juntar) strings.
                //⬇// $: permite interpolar strings, inserindo variáveis dentro do texto usando {}
Console.WriteLine($"A banda {nomedaBanda} registrada com sucesso!");
 // Thread: representa uma linha de execução do programa, permitindo rodar tarefas simultaneamente.
 Thread.Sleep(2000);
 Console.Clear();
 Main();
}


Main();
//⬆//
//this is the call of the function, it will execute the code inside the body of the function.// 
