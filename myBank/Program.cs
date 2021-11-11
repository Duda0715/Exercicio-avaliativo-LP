using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteFabiana = new Gerente()
            {
                Nome = "Fabiana Beatriz",
                CPF = "111.222.333-44",
                Salario = 20000,
                NumeroAgencias = 3,
            };
            gerenteFabiana.Bonificacao = gerenteFabiana.Salario;

            Vendedor vendedorLucas = new Vendedor()
            {
                Nome = "Lucas Kauã",
                CPF = "222.333.444-55",
                Salario = 4000,
                NumeroClientesAtendidos = 5,
            };
            vendedorLucas.Bonificacao = vendedorLucas.Salario;

            Vendedor vendedorLuna = new Vendedor()
            {
                Nome = "Luna Ribeiro",
                CPF = "333.444.555-66",
                Salario = 2000,
                NumeroClientesAtendidos = 5,
            };
            vendedorLuna.Bonificacao = vendedorLuna.Salario;

            Vendedor vendedorIsrael = new Vendedor()
            {
                Nome = "Israel Rosa",
                CPF = "444.555.666-77",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };
            vendedorIsrael.Bonificacao = vendedorIsrael.Salario;

            ContaCorrente contaDaDuda = new ContaCorrente("Maria Eduarda Silveira e Silva", "111.222.333-55", 789, 2000, vendedorIsrael);
            contaDaDuda.Conta = 890;

            ContaCorrente contaDoVicente = new ContaCorrente("Vicente Souza", "111.222.333-66", 987, 1200, vendedorLucas);
            contaDoVicente.Conta= 809;

            ContaCorrente contaDaGiovana = new ContaCorrente("Giovana Silva", "111.222.333-77", 988, 1500, vendedorLuna);
            contaDaGiovana.Conta= 980;
            
            Console.WriteLine("Contas correntes: ");
            Console.WriteLine("Conta 1: \nNome: "+contaDaDuda.Nome+
            "\nCPF: "+contaDaDuda.CPF+
            "\nAgência: "+contaDaDuda.Agencia+
            "\nConta: "+contaDaDuda.Conta+
            "\nSaldo: "+contaDaDuda.Saldo);

            Console.WriteLine("\nConta 3: \nNome: "+contaDoVicente.Nome+
            "\nCPF: "+contaDoVicente.CPF+
            "\nAgência: "+contaDoVicente.Agencia+
            "\nConta: "+contaDoVicente.Conta+
            "\nSaldo: "+contaDoVicente.Saldo);

            Console.WriteLine("\nConta 2: \nNome: "+contaDaGiovana.Nome+
            "\nCPF: "+contaDaGiovana.CPF+
            "\nAgência: "+contaDaGiovana.Agencia+
            "\nConta: "+contaDaGiovana.Conta+
            "\nSaldo: "+contaDaGiovana.Saldo);

            Console.WriteLine("\nFuncionários: ");
            Console.WriteLine("Vendedor 1: \nNome: "+vendedorLucas.Nome+
            "\nCPF: "+vendedorLucas.CPF+
            "\nSalário: "+vendedorLucas.Salario+
            "\nNúmero de clientes atendidos: "+vendedorLucas.NumeroClientesAtendidos+
            "\nComissão: "+vendedorLucas.Comissao+
            "\nBonificação anual: "+vendedorLucas.Bonificacao+
            "\nRemuneração total: "+vendedorLucas.RemuneracaoTotal(vendedorLucas.Salario, vendedorLucas.Bonificacao)+
            "\nDias de férias: "+vendedorLucas.CalcularFerias());

            Console.WriteLine("\nVendedor 2: \nNome: "+vendedorLuna.Nome+
            "\nCPF: "+vendedorLuna.CPF+
            "\nSalário: "+vendedorLuna.Salario+
            "\nNúmero de clientes atendidos: "+vendedorLuna.NumeroClientesAtendidos+
            "\nComissão: "+vendedorLuna.Comissao+
            "\nBonificação anual: "+vendedorLuna.Bonificacao+
            "\nRemuneração total: "+vendedorLuna.RemuneracaoTotal(vendedorLuna.Salario, vendedorLuna.Bonificacao)+
            "\nDias de férias: "+vendedorLuna.CalcularFerias());

            Console.WriteLine("\nVendedor 3: \nNome: "+vendedorIsrael.Nome+
            "\nCPF: "+vendedorIsrael.CPF+
            "\nSalário: "+vendedorIsrael.Salario+
            "\nNúmero de clientes atendidos: "+vendedorIsrael.NumeroClientesAtendidos+
            "\nComissão: "+vendedorIsrael.Comissao+
            "\nBonificação anual: "+vendedorIsrael.Bonificacao+
            "\nRemuneração total: "+vendedorIsrael.RemuneracaoTotal(vendedorIsrael.Salario, vendedorIsrael.Bonificacao)+
            "\nDias de férias: "+vendedorIsrael.CalcularFerias());

            Console.WriteLine("\nGerente: \nNome: "+gerenteFabiana.Nome+
            "\nCPF: "+gerenteFabiana.CPF+
            "\nSalário: "+gerenteFabiana.Salario+
            "\nNúmero de agências: "+gerenteFabiana.NumeroAgencias+
            "\nBonificação anual: "+gerenteFabiana.Bonificacao+
            "\nRemuneração total: "+gerenteFabiana.RemuneracaoTotal(gerenteFabiana.Salario, gerenteFabiana.Bonificacao)+
            "\nDias de férias: "+gerenteFabiana.CalcularFerias());

            Console.WriteLine("\nTotal de contas criadas: "+ContaCorrente.TotalContas);
        }
    }
}