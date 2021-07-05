using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    public class ContaEspecial : Conta
    {
        private double limiteEspecial;

        public double LimiteEspecial { get => limiteEspecial; set => limiteEspecial = value; }

        
        public String ConsultarContaEspecial()
        {
                return "\nTipo: \t\t\tCONTA ESPECIAL"
                    + ConsultarConta()
                    + "\nLimite especial: \t" + LimiteEspecial
                    + "\n";
        }

        public void DepositarContaEspecial(double deposito)
        {
            VerSaldoContaEspecial();
            Saldo += deposito;
        }

        public double VerSaldoContaEspecial()
        {
            return Saldo + LimiteEspecial;            
        }

        public String SacarContaEspecial(double saque)
        {

            double previa = VerSaldoContaEspecial();
            return Sacar(previa, saque);

        }

    }

}
