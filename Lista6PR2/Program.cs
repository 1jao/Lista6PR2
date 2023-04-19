using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    menu");
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:
                    float total = 0;
                    int totalItens = 0;
                    for (; ; )
                    {
                        Console.WriteLine("quantos itens foram comprados");
                        int quant = int.Parse(Console.ReadLine());

                        if (quant <= 0)
                            break;

                        Console.WriteLine("qual o valor de sua compra?");
                        float compra = float.Parse(Console.ReadLine());

                        Console.WriteLine("\n\n o programa não funcionará quando valor for igual a 0 \n\n");

                        totalItens += quant;
                        total += quant * compra;
                    }
                    Console.WriteLine("valor total a se pagar: " + total, " quantidade de itens que você comprou: " + totalItens);

                    break;

                case 2:

                    string[] nomesProdutos = new string[100];
                    int[] numItensProdutos = new int[100];
                    double[] precoCompraProdutos = new double[100];

                    int index = 0;

                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("qual o nome do produto (ou digite 'fim' para sair): ");
                        string nomeProduto = Console.ReadLine();

                        if (nomeProduto == "fim")
                        {
                            break;
                        }

                        Console.WriteLine("Digite o número de itens: ");
                        int numItens = int.Parse(Console.ReadLine());

                        Console.WriteLine("qual o preço da compra? : ");
                        double precoCompra = double.Parse(Console.ReadLine());

                        nomesProdutos[index] = nomeProduto;
                        numItensProdutos[index] = numItens;
                        precoCompraProdutos[index] = precoCompra;

                        index++;
                    }

                    string nomeMaiorInvestimento = "";
                    double maiorInvestimento = double.MinValue;

                    string nomeMenorInvestimento = "";
                    double menorInvestimento = double.MaxValue;

                    for (int i = 0; i < index; i++)
                    {
                        double totalInvestido = numItensProdutos[i] * precoCompraProdutos[i];

                        if (totalInvestido > maiorInvestimento)
                        {
                            maiorInvestimento = totalInvestido;
                            nomeMaiorInvestimento = nomesProdutos[i];
                        }

                        if (totalInvestido < menorInvestimento)
                        {
                            menorInvestimento = totalInvestido;
                            nomeMenorInvestimento = nomesProdutos[i];
                        }
                    }

                    Console.WriteLine($"produto com maior investimento: {nomeMaiorInvestimento} ({maiorInvestimento:C})");
                    Console.WriteLine($"produto com menor investimento: {nomeMenorInvestimento} ({menorInvestimento:C})");

                    break;

                case 3:
                    Console.Write("qual o número de avaliações? ");
                    int numAvl = int.Parse(Console.ReadLine());

                    double somaPesos = 0;
                    for (int i = 1; i <= numAvl; i++)
                    {
                        Console.Write($"qual o peso da avaliação? {i}: ");
                        double pesoo = double.Parse(Console.ReadLine());
                        somaPesos += pesoo;
                    }

                    if (somaPesos < 100)
                    {
                        Console.WriteLine($"A soma total dos pesos é insuficiente ({somaPesos}%).");
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine($"A soma total dos pesos é excedente ({somaPesos}%).");
                    }
                    else
                    {
                        Console.WriteLine($"A soma total dos pesos é adequada ({somaPesos}%).");
                    }
                    break;

                case 4:
                    Console.Write("qual a sigla do estado? ");
                    string sigla = Console.ReadLine().ToUpper();

                    string nomeEstado;

                    switch (sigla)
                    {
                        case "AC":
                            nomeEstado = "Acre";
                            break;
                        case "AL":
                            nomeEstado = "Alagoas";
                            break;
                        case "AP":
                            nomeEstado = "Amapá";
                            break;
                        case "AM":
                            nomeEstado = "Amazonas";
                            break;
                        case "BA":
                            nomeEstado = "Bahia";
                            break;
                        case "CE":
                            nomeEstado = "Ceará";
                            break;
                        case "DF":
                            nomeEstado = "Distrito Federal";
                            break;
                        case "ES":
                            nomeEstado = "Espírito Santo";
                            break;
                        case "GO":
                            nomeEstado = "Goiás";
                            break;
                        case "MA":
                            nomeEstado = "Maranhão";
                            break;
                        case "MT":
                            nomeEstado = "Mato Grosso";
                            break;
                        case "MS":
                            nomeEstado = "Mato Grosso do Sul";
                            break;
                        case "MG":
                            nomeEstado = "Minas Gerais";
                            break;
                        case "PA":
                            nomeEstado = "Pará";
                            break;
                        case "PB":
                            nomeEstado = "Paraíba";
                            break;
                        case "PR":
                            nomeEstado = "Paraná";
                            break;
                        case "PE":
                            nomeEstado = "Pernambuco";
                            break;
                        case "PI":
                            nomeEstado = "Piauí";
                            break;
                        case "RJ":
                            nomeEstado = "Rio de Janeiro";
                            break;
                        case "RN":
                            nomeEstado = "Rio Grande do Norte";
                            break;
                        case "RS":
                            nomeEstado = "Rio Grande do Sul";
                            break;
                        case "RO":
                            nomeEstado = "Rondônia";
                            break;
                        case "RR":
                            nomeEstado = "Roraima";
                            break;
                        case "SC":
                            nomeEstado = "Santa Catarina";
                            break;
                        case "SP":
                            nomeEstado = "São Paulo";
                            break;
                        case "SE":
                            nomeEstado = "Sergipe";
                            break;
                        case "TO":
                            nomeEstado = "Tocantins";
                            break;
                        default:
                            nomeEstado = "";
                            break;
                    }

                    if (nomeEstado == "")
                    {
                        Console.WriteLine("Sigla de estado inválida!");
                    }
                    else
                    {
                        Console.WriteLine($"O estado correspondente à sigla {sigla} é {nomeEstado}.");
                    }
                    break;


                case 5:
                    Console.Write("Digite um número inteiro entre 1 e 12: ");
                    int mes = int.Parse(Console.ReadLine());

                    string estacao = "";
                    switch (mes)
                    {
                        case 12:
                        case 1:
                        case 2:
                            estacao = "Inverno";
                            break;
                        case 3:
                        case 4:
                        case 5:
                            estacao = "Primavera";
                            break;
                        case 6:
                        case 7:
                        case 8:
                            estacao = "Verão";
                            break;
                        case 9:
                        case 10:
                        case 11:
                            estacao = "Outono";
                            break;
                        default:
                            Console.WriteLine("Mês inválido!");
                            return;
                    }

                    if (estacao == "Primavera" || estacao == "Outono")
                    {
                        Console.Write("O mês digitado pode ser " + estacao + ", porém ele ocorre em duas estações. ");
                        Console.Write("Digite '1' para " + estacao + " do início do mês até o dia 20, ou '2' para " + estacao + " do dia 21 até o final do mês: ");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            if (estacao == "Primavera")
                            {
                                estacao = "Primavera (início)";
                            }
                            else
                            {
                                estacao = "Outono (início)";
                            }
                        }
                        else if (escolha == 2)
                        {
                            if (estacao == "Primavera")
                            {
                                estacao = "Primavera (fim)";
                            }
                            else
                            {
                                estacao = "Outono (fim)";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Escolha inválida!");
                            return;
                        }
                    }

                    Console.WriteLine("O mês digitado corresponde à estação: " + estacao);

                    break;

                case 6:
                    Console.Write("Digite seu peso (em kg): ");
                    double peso = double.Parse(Console.ReadLine());

                    Console.Write("Digite sua altura (em metros): ");
                    double altura = double.Parse(Console.ReadLine());

                    double imc = peso / (altura * altura);

                    Console.Write("Seu IMC é: " + imc + " - ");

                    if (imc < 18.5)
                    {
                        Console.WriteLine("Você está abaixo do peso");
                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        Console.WriteLine("seu peso é considerado normal");
                    }
                    else if (imc >= 25.0 && imc <= 29.9)
                    {
                        Console.WriteLine("Você está acima de seu peso ideal");
                    }
                    else if (imc >= 30.0 && imc <= 34.9)
                    {
                        Console.WriteLine("Obesidade grau 1");
                    }
                    else if (imc >= 35.0 && imc <= 39.9)
                    {
                        Console.WriteLine("Obesidade grau 2");
                    }
                    else
                    {
                        Console.WriteLine("Obesidade grau 3 (mórbida)");
                    }

                    break;

                case 7:
                    Console.Write("Digite um número inteiro positivo: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de " + n + ":");
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
            }
        }
    }
}