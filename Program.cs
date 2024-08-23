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
                    Opcao1();

                    break;
                case "2":
                    Opcao2();

                    break;
                case "3":
                    Opcao3();
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
static Estoque estoque = new Estoque();
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

        estoque.Novo(nome, valor, tipo, fornecedor, medida);
        
    
    }
static void Opcao2(){
    estoque.ListarProdutos();
}

static void Opcao3(){
    Console.WriteLine(" digite o numero do produto em sua lista ");
    string numero = Console.ReadLine();
    if (int.TryParse(numero, out int numerador))
    {
        estoque.RemoverProdutos(numerador);
    }

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
        return $"{Numero}. {Nome} - {Valor} - {Tipo} - {Fornecedor} - {Medida} - {Estoque} Estoque";

    }

}
class Estoque{
    static List<Pedras> pedras = new List<Pedras>();
    static int contador = 1;

    public void Novo(string nome, string valor, string tipo, string fornecedor, string medida) {
        Pedras material = new Pedras {
            Numero = contador, Nome = nome, Valor = valor, Tipo = tipo, Fornecedor = fornecedor, Medida = medida, Estoque = 0
        };

    pedras.Add(material);
    contador++; Console.WriteLine("Produto adcionado");

    }
    public void ListarProdutos(){
        if (pedras.Count == 0)

        {Console.WriteLine(" sua lista está vazia.");
        
            
        }else
        {
            foreach (var  pedra in pedras)
            {
                Console.WriteLine(pedra);
            }
        }
    }
     public void RemoverProdutos(int numero){
        var produtoRemovido = pedras.FirstOrDefault(a=>a.Numero == numero);
        if (produtoRemovido == null)
            
    
        { Console.WriteLine("Esse produto não existe.");
            
        }
else
{
    pedras.Remove( produtoRemovido );
     Console.WriteLine("Seu produto foi removido com sucesso.");
}
     }

}