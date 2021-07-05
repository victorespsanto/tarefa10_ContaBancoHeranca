using System;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial ce = new ContaEspecial();
            ContaPoupanca cp = new ContaPoupanca();

            Console.WriteLine("\n========== ABERTURA DE CONTA ===========\n");

            int tipoConta;

            Console.WriteLine("1 - CONTA ESPECIAL");
            Console.WriteLine("2 - CONTA POUPANÇA\n");

            Console.Write("Informe o tipo de conta que pretende abrir: ");
            tipoConta = int.Parse(Console.ReadLine());

            bool flag = true;
           
            while (flag)
            {
                if (tipoConta == 1 || tipoConta == 2)
                {
                    flag = false;                               
                } else
                {
                    Console.Write("Informe corretamente o índice do tipo de conta: ");
                    tipoConta = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\n==== DADOS PARA ABERTURA DE CONTA ====\n");

            Console.Write("Nome do titular: ");
            String nome = Console.ReadLine();

            Console.Write("CPF do titular: ");
            String cpf = Console.ReadLine();

            Console.Write("Número da conta: ");
            String num_conta = Console.ReadLine();

            DateTime dt_abertura = DateTime.Now;

            int situacao = 1;

            Console.Write("Escolha uma senha: ");
            String senha = Console.ReadLine();

            flag = true;

            while (flag)
            {
                Console.Write("Confirme a senha: ");
                String confSenha = Console.ReadLine();

                if (senha == confSenha)
                {
                    flag = false;
                } else
                {
                    Console.WriteLine("As senhas não conferem.");
                }

            }

            double limite = 0;
            int dt_aniversario = 0;


            if (tipoConta == 1)
            {
                Console.Write("Informe o valor do limite especial: ");
                limite = double.Parse(Console.ReadLine());                
                ce.AbrirConta(nome, cpf, num_conta, dt_abertura, situacao, senha);
                ce.LimiteEspecial = limite;
            } else
            {
                dt_aniversario = (DateTime.Now).Day;                
                cp.AbrirConta(nome, cpf, num_conta, dt_abertura, situacao, senha);
                cp.Dt_aniversario = dt_aniversario;
            }

            string sair;

            Console.Write("\nDados incluídos com SUCESSO!! Deseja continuar? (S/N) ");
            sair = (Console.ReadLine()).ToUpper();

            flag = true;

            while (flag)
            {

                if (sair == "S" || sair == "N")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("\nEscolha entre SIM (S) e NÃO (N): ");
                    sair = (Console.ReadLine()).ToUpper();
                }

            }

            int opcaoUsuario = 0;

            if (sair == "N")
            {
                Console.Clear();
                Console.WriteLine("\nPROGRAMA ENCERRADO. TECLE QUALQUER TECLA PARA SAIR.");
                Environment.Exit(0);

            }
            else
            {
                while (sair == "S")
                {
                    Console.Clear();
                    Console.WriteLine("\n========== OPÇÕES PARA O USUÁRIO ===========\n");
                    Console.WriteLine("1 - CONSULTAR SEUS DADOS");
                    Console.WriteLine("2 - DESPOSITAR");
                    Console.WriteLine("3 - VER SALDO");
                    Console.WriteLine("4 - SACAR");
                    Console.WriteLine("5 - ENCERRAR CONTA\n");
                    Console.Write("Informe o serviço desejado: ");
                    opcaoUsuario = int.Parse(Console.ReadLine());


                    flag = true;

                    while (flag)
                    {
                        if (opcaoUsuario >= 1 && opcaoUsuario <= 5)
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.Write("\nInforme o serviço desejado corretamente: ");
                            opcaoUsuario = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.Clear();

                    switch (opcaoUsuario)
                    {
                        case 1:
                            if (tipoConta == 1)
                            {
                                Console.WriteLine(ce.ConsultarContaEspecial());
                            }
                            else
                            {
                                Console.WriteLine(cp.ConsultarContaPoupanca());
                            }
                            break;

                        case 2:
                            Console.Write("\nInforme o valor do depósito: ");
                            double deposito = double.Parse(Console.ReadLine());

                            if (tipoConta == 1)
                            {
                                ce.DepositarContaEspecial(deposito);
                            }
                            else
                            {
                                cp.Depositar(deposito);
                            }
                            break;

                        case 3:
                            if (tipoConta == 1)
                            {
                                Console.WriteLine("\nSaldo da conta: " + ce.VerSaldoContaEspecial());
                            }
                            else
                            {
                                Console.WriteLine("\nSaldo da conta: " + cp.VerSaldo());
                            }
                            break;

                        case 4:
                            Console.Write("\nInforme o valor de saque: ");
                            double saque = double.Parse(Console.ReadLine());

                            if (tipoConta == 1)
                            {
                                Console.WriteLine(ce.SacarContaEspecial(saque));
                            }
                            else
                            {
                                Console.WriteLine(cp.Sacar(cp.Saldo, saque));
                            }
                            break;

                    }

                    Console.Write("\nDeseja verificar outro serviço (S/N): ");
                    sair = (Console.ReadLine()).ToUpper();

                    flag = true;

                    while (flag)
                    {

                        if (sair == "S" || sair == "N")
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha entre SIM (S) e NÃO (N): ");
                            sair = (Console.ReadLine()).ToUpper();
                        }

                    }
                }
            }
        }
    }
}
