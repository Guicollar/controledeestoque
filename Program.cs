using System.ComponentModel.Design; 
using System;
using System.Runtime.InteropServices;

namespace controleestoque;

class Program
{

    static void Main(string[] args)
    {
        Menu();
        
    }
static List<Pedras> pedras = new List<Pedras>();
static int contador = 1;
    static void Menu(){
        Console.WriteLine("Bem vindo ao menu \n");
        Console.WriteLine("1. Novo");
        Console.WriteLine("2. Listar os produtos");
        Console.WriteLine("3. Remover os produtos");
        Console.WriteLine("4. Entrada de estoque");
        Console.WriteLine("5. Saída de estoque");
        Console.WriteLine("0. Sair do menu");
        Console.WriteLine("Escolha uma opção");

        string? escolha = Console.ReadLine();
        
            switch (escolha)
            {
                case "1":
                    Console.WriteLine("opção 1");
                    break;
                case "2":
                    Console.WriteLine("opção 2");
                    break;
                case "3":
                    Console.WriteLine("opção 3");
                    break;
                case "4":
                    Console.WriteLine("opção 4");
                    break;
                case "5":
                    Console.WriteLine("opção 5");
                    break;
                case "0":
                    Console.WriteLine("Saindo");
                    return;
            }   
            Menu();
    }
    static void Opcao1(){
        Console.WriteLine(" digite o nome do material");
        string nome = Console.ReadLine();
        Console.WriteLine("digite o valor");
        string valor = Console.ReadLine();
        Console.WriteLine(" digite o tipo");
        string tipo = Console.ReadLine();
        Console.WriteLine(" digite o fornecedor");
        string fornecedor = Console.ReadLine();
        Console.WriteLine("digite a medida");
        string medida = Console.ReadLine();
        
        
    }
}
 class Pedras {
    public int Numero {get; set;}
    public string Nome {get; set;}
    public string Valor {get; set;}
    public string Tipo {get; set;}
    public string Fornecedor { get; set;}
    public  string Medida { get; set;}
    public int Estoque {get; set;}

    public override string ToString()
    {
        return $"{Numero}. {Nome} - {Valor} - {Tipo} - {Fornecedor} {Medida} - {Estoque} Estoque";

    }

}