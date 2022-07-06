using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Av
{
    internal class Program
    {
        /*Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe o código da cidade escolhida. Em seguida pedir uma data para o usuário. Ao final deve ser apresentada em tela a data completa em formato extenso longo, juntamente com a cidade escolhida. 
        Exemplo: Bragança Paulista, 29 de junho de 2022.
        A relação das cidades é a seguinte:
        1 – Atibaia
        2 – Bragança Paulista
        3 – Mairiporã
        4 – Nazaré
        5 – Terra Preta
        6 – Extrema
        7 – Vargem
        Requisitos: Criar uma função para converter a data em extenso.*/
        public static void Main()
        {
            string DataAtual;
            int codigo;
            Console.WriteLine("Digite o código da cidade: \n1 – Atibaia \n2 – Bragança Paulista \n3 – Mairiporã \n4 – Nazaré \n5 – Terra Preta \n6 – Extrema \n7 – Vargem");
            codigo= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a data: \n[Formato: DD/MM/AAAA]");
            DataAtual = Console.ReadLine();
            Console.WriteLine(mesExtenso(Convert.ToDateTime(DataAtual)));
            if (codigo == 1)
            {
                Console.Write("Atibaia");
            }
            else if (codigo == 2)
            {
                Console.Write("Bragança Paulista");
            }
            else if (codigo == 3)
            {
                Console.Write("Mairiporã");
            }
            else if (codigo == 4)
            {
                Console.Write("Nazaré");
            }
            else if (codigo == 5)
            {
                Console.Write("Terra Preta");
            }
            else if (codigo == 6)
            {
                Console.Write("Extrema");
            }
            else if (codigo == 7)
            {
                Console.Write("Vargem");
            }
            Console.ReadKey();
        }
        static public string mesExtenso(DateTime DataAtual)
        {
            int dia, mes, ano;
            string mesExtenso = null;
            mes = DataAtual.Month;
            dia = DataAtual.Day;
            ano = DataAtual.Year;
            switch (mes)
            {
                case 1:
                    mesExtenso = "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Março";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
            }
            return dia + " de " + mesExtenso + " de " + ano;
            
        }
    }
}
