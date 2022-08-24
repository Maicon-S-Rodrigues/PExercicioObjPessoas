using System;

namespace PExercicioObjPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pessoa;
            int diaNasc, mesNasc, anoNasc;
            int cpf, telefone;
            Pessoa pessoaObj1 = new Pessoa();
            Pessoa pessoaObj2 = new Pessoa();
            Pessoa pessoaObj3 = new Pessoa();

            ///////////////////////////////////////////////////////////////////////////
            ///Inserir dados no Objeto Pessoa1
            Console.WriteLine("Inserção de dados da Primeira Pessoa:\n" +
                              "Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Informe o nome da Primeira pessoa no cadastro: ");
            pessoa = Console.ReadLine();
            pessoaObj1.setNome(pessoa);

            Console.WriteLine("Dia de Nascimento: ");
            diaNasc = int.Parse(Console.ReadLine());
            pessoaObj1.setDiaNasc(diaNasc);

            Console.WriteLine("Mês de Nascimento: ");
            mesNasc = int.Parse(Console.ReadLine());
            pessoaObj1.setMesNasc(mesNasc);

            Console.WriteLine("Ano de Nascimento: ");
            anoNasc = int.Parse(Console.ReadLine());
            pessoaObj1.setAnoNasc(anoNasc);

            Console.WriteLine("11 digitos do CPF: ");
            cpf = int.Parse(Console.ReadLine());
            pessoaObj1.setCPF(cpf);

            Console.WriteLine("Telefone: ");
            telefone = int.Parse(Console.ReadLine());
            pessoaObj1.setTelefone(telefone);

            ///////////////////////////////////////////////////////////////////////////
            ///Inserir dados no Objeto Pessoa2
            Console.Clear();
            Console.WriteLine("Inserção de dados da Segunda Pessoa:\n" +
                              "Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Informe o nome da Segunda pessoa no cadastro: ");
            pessoa = Console.ReadLine();
            pessoaObj2.setNome(pessoa);

            Console.WriteLine("Dia de Nascimento: ");
            diaNasc = int.Parse(Console.ReadLine());
            pessoaObj2.setDiaNasc(diaNasc);

            Console.WriteLine("Mês de Nascimento: ");
            mesNasc = int.Parse(Console.ReadLine());
            pessoaObj2.setMesNasc(mesNasc);

            Console.WriteLine("Ano de Nascimento: ");
            anoNasc = int.Parse(Console.ReadLine());
            pessoaObj2.setAnoNasc(anoNasc);

            Console.WriteLine("11 digitos do CPF: ");
            cpf = int.Parse(Console.ReadLine());
            pessoaObj2.setCPF(cpf);

            Console.WriteLine("Telefone: ");
            telefone = int.Parse(Console.ReadLine());
            pessoaObj2.setTelefone(telefone);

            ///////////////////////////////////////////////////////////////////////////
            ///Inserir dados no Objeto Pessoa1
            Console.Clear();
            Console.WriteLine("Inserção de dados da Terceira Pessoa:\n" +
                              "Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Informe o nome da Terceira pessoa no cadastro: ");
            pessoa = Console.ReadLine();
            pessoaObj3.setNome(pessoa);

            Console.WriteLine("Dia de Nascimento: ");
            diaNasc = int.Parse(Console.ReadLine());
            pessoaObj3.setDiaNasc(diaNasc);

            Console.WriteLine("Mês de Nascimento: ");
            mesNasc = int.Parse(Console.ReadLine());
            pessoaObj3.setMesNasc(mesNasc);

            Console.WriteLine("Ano de Nascimento: ");
            anoNasc = int.Parse(Console.ReadLine());
            pessoaObj3.setAnoNasc(anoNasc);

            Console.WriteLine("11 digitos do CPF: ");
            cpf = int.Parse(Console.ReadLine());
            pessoaObj3.setCPF(cpf);

            Console.WriteLine("Telefone: ");
            telefone = int.Parse(Console.ReadLine());
            pessoaObj3.setTelefone(telefone);

            ////////////////////////////////////////////////////////////////////////
            ///Mostrar na tela:
            ///
            Console.Clear();
            Console.WriteLine("\nDados da Primeira Pessoa: " + pessoaObj1.ToString());
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nDados da Primeira Pessoa: " + pessoaObj2.ToString());
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nDados da Primeira Pessoa: " + pessoaObj2.ToString());
            Console.WriteLine("\n----------------------------------------------------------");


        }
    }
}
