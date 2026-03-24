
namespace Fundamentos01;

public class VariaveisETiposDeDados
{

    string sobreNome = "Pinheiro";

    public void Executar()
    {
       Console.WriteLine("📦 VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine(); 

        int idade =25;
        double altura =1.75;
        float media = 1950;
        char letra = 'A';
        string nome = "Jorge";
        string nomeCompleto = nome + " Magalhães";
        bool estudante = true;


        Console.WriteLine($"int -> idade: {idade} (numeros inteiros)");
        Console.WriteLine($"double -> altura: {altura} (numeros décimais)");
        Console.WriteLine($"char -> letra: {letra} (um único caracter)");
        Console.WriteLine($"string -> nome: {nomeCompleto} (texto)");
        Console.WriteLine($"bool -> estudante: {estudante} (booleano que é verdadeiro ou falso)");
        Console.WriteLine($"variavel global -> Sobrenome: {this.sobreNome} (variável global)");

    }



}// fim da class