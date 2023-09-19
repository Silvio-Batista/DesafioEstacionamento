using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoHora = 0;
        private List<string> Carros = new List<string>();

        public Estacionamento(decimal PrecoInicial, decimal PrecoHora){
            this.PrecoInicial = PrecoInicial;
            this.PrecoHora = PrecoHora;
        }
        public void adicionarVeiculo(){
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            Carros.Add(Console.ReadLine());
        }
        public void RemoverVeiculo(){
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string? Placa = "";
            Placa = Console.ReadLine();

            if(Carros.Any(x => x.ToUpper() == Placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o carro ficou estacionado: ");
                int Horas = 0;
                Horas = Convert.ToInt32(Console.ReadLine());
                decimal ValorTotal = PrecoInicial + (PrecoHora * Horas);

                Console.WriteLine($"O veículo {Placa} foi removido e o praço total foi de R$ {ValorTotal}");
                Carros.Remove(Placa);
            }
            else{
                Console.WriteLine("Este veículo não está cadastrado. Por favor, verifique novamente a placad");
            }
        }
        public void ListarCarro(){
            if (Carros.Any()){
                Console.WriteLine("Os veículos estacionados são: ");
                foreach (string carro in Carros)
                {
                    Console.WriteLine(carro);
                };
            }
            else{
                Console.WriteLine("Não Há veículos estacionados");
            }
        }
    }
}