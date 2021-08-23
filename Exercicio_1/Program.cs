using System;
using System.Collections.Generic;
using Exercicio_1.Classes;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						CalcularIdade();
						break;
					case "2":
						CalcularIMC();
						break;
					case "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }
        private static void CalcularIdade()
		{
			Console.WriteLine("Siga as instruções abaixo para calcular sua idade!");

			Console.Write("Digite o ano que você nasceu: ");
			int entradaAnoNasc = int.Parse(Console.ReadLine());
            
			Console.Write("Digite o ano atual: ");
			int entradaAno = int.Parse(Console.ReadLine());

            idade = entradaAno - entradaAnoNasc;

            Console.Write("Sua idade é: {0} " , idade);

		}

        private static void CalcularIMC()
		{
			Console.Write("Digite o seu peso:");
            peso = float.Parse(Console.ReadLine());


            Console.Write("Digite o seu altura:");
            altura =  float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal");
            }
            else  if ((imc > 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30) && (imc < 35))
            {
                Console.WriteLine("Grau de Obesidade I");
            }
            else if ((imc > 35) && (imc < 40))
            {
                Console.WriteLine("Grau de Obesidade II");
            }
            else  if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }

            Console.ReadKey();

		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Seja Bem-Vindo a Calculadora!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Calcular Idade");
			Console.WriteLine("2- Calcular IMC");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
