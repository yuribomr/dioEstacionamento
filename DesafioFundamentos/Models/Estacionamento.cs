using static Carro;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 15;
        private decimal precoPorHora = 5;
        private List<string> veiculos = new List<string>();

        private List<Carro> carros = new List<Carro>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();
            var carro = new Carro(placa);
            /* Codigo Antigo
             veiculos.Add(placa); */
            carros.Add(carro);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            for (int i = 0; i < carros.Count; i++)
            {
                if (carros[i].Placa == placa)
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    var consumo = Console.ReadLine();

                    int horas = Convert.ToInt32(consumo);
                    decimal valorTotal = (precoInicial + precoPorHora) * horas;

                    for (int j = 0; j < carros.Count; j++)
                    {
                        if (carros[j].Placa.Equals(placa))
                        {
                            carros.RemoveAt(j);
                        }
                    }
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (carros.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                /*int contador = 0;
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"Veiculo na vaga {contador} e a placa é {veiculo}");
                    contador++;
                }*/  // Codigo Antigo
                for (int i = 0; i < carros.Count; i++)
                {
                    Console.WriteLine($"Veiculo na vaga {i} e a placa é {carros[i]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
