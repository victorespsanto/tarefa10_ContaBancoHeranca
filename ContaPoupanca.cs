using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    class ContaPoupanca : Conta
    {
        private int dt_aniversario;

        public int Dt_aniversario { get => dt_aniversario; set => dt_aniversario = value; }

        public String ConsultarContaPoupanca()
        {
            return "\nTipo: \t\t\tCONTA POUPANÇA"
                + ConsultarConta()                    
                + "\nDia de rendimento: \t" + Dt_aniversario
                + "\n";
        }

    }
}
