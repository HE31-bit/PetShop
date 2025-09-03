//Adicionando as bibliotecas
using System;
using System.Collections.Generic;

class Animal
{
    //Adicionando os parametrôs nome e idade do animal
    public string Nome;
    public int Idade;

    //Construtor dos parâmetros
    public Animal (string n, int i)
    {
        Nome = n;
        Idade = i;
    }

    //F
    public virtual void EmitirSom()
    {
        ;
    }
    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
    }
}

class Cachorro : Animal
{
    public string Raca;

    public Cachorro (string n, string r, int i) : base(n, i)
    {
        Raca = r;
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Au Au");
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Raça: {Raca}");
    }
}

class Gato : Animal
{
    public string Cor;

    public Gato (string n, string c, int i) : base(n,i)
    {
        Cor = c;
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau");
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Cor: {Cor}");
    }
}

class PetSop
{
    public List<Animal> Animais = new List<Animal> ();


    public void AdicionarAnimal(Animal a)
    {
        Animais.Add(a);
    }
    public void ListarAnimais()
    {
        foreach (var i in Animais)
        {
            i.ExibirInfo();
            i.EmitirSom();
            Console.WriteLine();
        }
    }

}

class Program
{
static void Main()
{

Gato a = new Gato("Lisa", "Preto", 2);

PetSop b = new PetSop();
b.AdicionarAnimal(a);
b.ListarAnimais();

Cachorro g = new Cachorro ("Alberto", "salsicha", 1);

PetSop c = new PetSop();
c.AdicionarAnimal(g);
c.ListarAnimais();

}
}





