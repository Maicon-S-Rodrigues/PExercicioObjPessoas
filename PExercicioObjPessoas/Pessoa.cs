using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioObjPessoas
{
    internal class Pessoa
    {
        ///Atributos:
        String nome;
        int diaNasc;
        int mesNasc;
        int anoNasc;
        String cpf;
        String numTelefone;

        ///Método Construtor (obs: NÃO ESQUECER!)
        public Pessoa ()
        {

        }
        //////////////////////////////////////////////////////

        public void setNome() /// Método SET para receber o nome
        {
            this.nome = Console.ReadLine();
        }
        public void setDiaNasc() // Método SET para receber o dia de nascimento
        {
            this.diaNasc = int.Parse(Console.ReadLine());
        }
        public void setMesNasc() // Método SET para receber o mês de nascimento
        {
            this.mesNasc = int.Parse(Console.ReadLine());
        }
        public void setAnoNasc() // Método SET para receber o ano de nascimento
        {
            this.anoNasc = int.Parse(Console.ReadLine());
        }
        public void setCPF() // Método SET para receber o CPF
        {
            this.cpf = Console.ReadLine();
        }
        public void setTelefone()
        {
            this.numTelefone = Console.ReadLine(); // Método SET para receber o Telefone
        }
        public override string ToString() // Método para escrever todos os atributos do objeto de uma só vez:
        {
            return "Nome: " + nome + "\nData de Nascimento: " + diaNasc + "/" + mesNasc + "/" + anoNasc + "\n" +
                   "CPF: " + cpf + "\nTelefone: " + numTelefone;
        }
    }
}
