using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sall = 0;
            double salb, vhora, qhora, desc, ir, peca, comi;
            string contrato;

            Console.WriteLine("Informe a forma de contratação: Assalariado(A), Comissionado(C), Horista(H)");
            contrato = Console.ReadLine().ToLower();
            switch (contrato)
            {
                case "a":
                    Console.WriteLine("Informe o salario bruto: ");
                    salb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o desconto: ");
                    desc = double.Parse(Console.ReadLine());
                    sall = salb-desc;

                    break;
                case "c":
                    Console.WriteLine("Informe a quantidade de peças: ");
                    peca = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da comissão: ");
                    comi = double.Parse(Console.ReadLine());
                    sall = peca*comi;
                    break;
                case "h":
                    Console.WriteLine("Informe o valor da hora: ");
                    vhora = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                    qhora = double.Parse(Console.ReadLine());
                    sall = vhora*qhora;
                    break;
                default: Console.WriteLine("Opção invalida!");
                    break;

            }
            //imposto de renda
            if (sall <= 2000)
            {
                ir = (sall * 0.075);
                Console.WriteLine("O imposto de renda é: " + ir);
                Console.WriteLine("O salario é: " + (sall-ir));

            }
            else if (sall <= 4000)
            {
                ir = (sall * 0.12);
                Console.WriteLine("O imposto de renda é: " + ir);
                Console.WriteLine("O salario é: " + (sall - ir));
            }
            else
            {
                ir = (sall * 0.15);
                Console.WriteLine("O imposto de renda é: " + ir);
                Console.WriteLine("O salario é: " + (sall - ir));
            }


            Console.ReadKey();
        }
    }
}
