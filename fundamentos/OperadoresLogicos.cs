namespace Fundamentos01;


public class OperadoresLogicos
{
 public void Executar()
    {
        Console.WriteLine("OPERADORES LÓGICOS");

        bool temIdade = true;
        bool temCarta = false;

        Console.WriteLine($"Tem idade? {temIdade}");
        Console.WriteLine($"Tem carta? {temCarta}");
        Console.WriteLine();
        Console.WriteLine($"Pode conduzir? {temIdade && temCarta}"); //and
        Console.WriteLine($"Pode tirar carta? {temIdade || temCarta}"); //or
        Console.WriteLine($"Não tem idade? {!temIdade}"); //not




    }






}
    