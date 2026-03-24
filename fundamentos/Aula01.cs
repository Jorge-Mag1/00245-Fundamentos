using Fundamentos01;

namespace Fundamentos;

public class Aula01
{

    public void ExecutarAula()
    {
        //inicio
        this.ExibirCabecalho();

        VariaveisETiposDeDados variaveisETiposDeDados = new VariaveisETiposDeDados();
        variaveisETiposDeDados.Executar();

        Console.WriteLine();

        //chamar a classe OperadoresAritmeticos
        OperadoresAritmeticos operadoresAritmeticos = new OperadoresAritmeticos();
        operadoresAritmeticos.Executar();

        Console.WriteLine();

        //chamar a classe OperadoresComparacao
        OperadoresComparacao operadoresComparacao = new OperadoresComparacao();
        operadoresComparacao.Executar();

        Console.WriteLine();

        //chamar a classe OperadoresLogicos
        OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
        operadoresLogicos.Executar();


        //fim
        this.ResumoAula();
        

    }


   private void ExibirCabecalho()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   AULA 01 - FUNDAMENTOS DE ALGORITMIA");
        Console.WriteLine("======================================");
        Console.WriteLine();
    }
 
    private void ResumoAula()
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("   FIM DA AULA - RESUMO");
        Console.WriteLine("======================================");
        Console.WriteLine("✓ O que é algoritmia");
        Console.WriteLine("✓ Variáveis e tipos de dados");
        Console.WriteLine("✓ Operadores aritméticos, comparação e lógicos");
        Console.WriteLine("✓ Estruturas de controle básicas");
    } 

}

    
    

  







    


