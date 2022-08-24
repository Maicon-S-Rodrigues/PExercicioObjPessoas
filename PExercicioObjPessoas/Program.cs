using System;

namespace PExercicioObjPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj1 = new Pessoa();
            Pessoa obj2 = new Pessoa();
            Pessoa obj3 = new Pessoa();

            Console.WriteLine("Inserindo dados no cadastro da Primeira pessoa: ");
            Console.WriteLine("\nNome: ");
            obj1.setNome();
            Console.WriteLine("\nDia de Nascimento: ");
            obj1.setDiaNasc();
            Console.WriteLine("\nMês de Nascimento: ");
            obj1.setMesNasc();
            Console.WriteLine("\nAno de Nascimento: ");
            obj1.setAnoNasc();
            Console.WriteLine("\nCPF: ");
            obj1.setCPF();
            Console.WriteLine("\nTelefone: ");
            obj1.setTelefone();
            /////////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("Inserindo dados no cadastro da Segunda pessoa: ");
            Console.WriteLine("\nNome: ");
            obj2.setNome();
            Console.WriteLine("\nDia de Nascimento: ");
            obj2.setDiaNasc();
            Console.WriteLine("\nMês de Nascimento: ");
            obj2.setMesNasc();
            Console.WriteLine("\nAno de Nascimento: ");
            obj2.setAnoNasc();
            Console.WriteLine("\nCPF: ");
            obj2.setCPF();
            Console.WriteLine("\nTelefone: ");
            obj2.setTelefone();
            /////////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("Inserindo dados no cadastro da Terceira pessoa: ");
            Console.WriteLine("\nNome: ");
            obj3.setNome();
            Console.WriteLine("\nDia de Nascimento: ");
            obj3.setDiaNasc();
            Console.WriteLine("\nMês de Nascimento: ");
            obj3.setMesNasc();
            Console.WriteLine("\nAno de Nascimento: ");
            obj3.setAnoNasc();
            Console.WriteLine("\nCPF: ");
            obj3.setCPF();
            Console.WriteLine("\nTelefone: ");
            obj3.setTelefone();
            ///////////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("\nDados da Primeira Pessoa: " + obj1.ToString());
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nDados da Primeira Pessoa: " + obj2.ToString());
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nDados da Primeira Pessoa: " + obj3.ToString());
            Console.WriteLine("\n----------------------------------------------------------");
        }
    }
}
