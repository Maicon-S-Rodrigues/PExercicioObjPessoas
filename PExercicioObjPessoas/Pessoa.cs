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
        int cpf;
        int numTelefone;

        public void setNome(String nome) /// Método SET para receber o nome
        {
            this.nome = nome;
        }
        public void setDiaNasc(int diaNasc) // Método SET para receber o dia de nascimento
        {
            this.diaNasc = diaNasc;
        }
        public void setMesNasc(int mesNasc) // Método SET para receber o mês de nascimento
        {
            this.mesNasc = mesNasc;
        }
        public void setAnoNasc(int anoNasc) // Método SET para receber o ano de nascimento
        {
            this.anoNasc = anoNasc;
        }

        public void setCPF(int cpf)
        {
            this.cpf = cpf;
        }
        public void setTelefone(int telefone)
        {
            this.numTelefone = telefone;
        }
        public override string ToString()
        {
            return "Nome: " + nome + "\nData de Nascimento: " + diaNasc + "/" + mesNasc + "/" + anoNasc + "\n" +
                   "CPF: " + cpf + "\nTelefone: " + numTelefone;
        }



        public String getNome ()
        {
            return nome;    
        }
    }
}
