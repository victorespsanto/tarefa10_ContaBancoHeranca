using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    public class Conta
    {
        private String nome_titular;
        private String cpf_titular;
        private String nro_conta;
        private DateTime? dt_abertura;
        private DateTime? dt_encerramento;
        private int situacao;
        private String senha;
        private double saldo = 0;


        public string Nome_titular { get => nome_titular; set => nome_titular = value; }
        public String Cpf_titular { get => cpf_titular; set => cpf_titular = value; }
        public String Nro_conta { get => nro_conta; set => nro_conta = value; }
        public DateTime? Dt_abertura { get => dt_abertura; set => dt_abertura = value; }
        public DateTime? Dt_encerramento { get => dt_encerramento; set => dt_encerramento = value; }
        public int Situacao { get => situacao; set => situacao = value; }
        public String Senha { get => senha; set => senha = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void AbrirConta(String nome, String cpf, String num_conta, DateTime dt_abertura, int situacao, String senha)
        {
            Nome_titular = nome;
            Cpf_titular = cpf;
            Nro_conta = num_conta;
            Dt_abertura = dt_abertura;
            Situacao = situacao;
            Senha = senha;
        }

        public String ConsultarConta()
        {
            return "\nNome do titular: \t" + Nome_titular
                + "\nCPF do titular: \t" + Cpf_titular
                + "\nNúmero da conta: \t" + Nro_conta
                + "\nData de abertura: \t" + Dt_abertura
                + "\nSituação: \t\t" + Situacao
                + "\nSenha: \t\t\t" + Senha;
        }

        public double VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public String Sacar(double previa, double saque)
        {
            
            if (previa >= saque)
            {
                Saldo -= saque;
                return "\nSAQUE AUTORIZADO!!";
            }
            else
            {
                return "\nSALDO INSUFICIENTE!!!";
            }

        }

    }
}
