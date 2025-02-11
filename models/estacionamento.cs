namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoinicial = 0;
        private decimal precoporhora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoinicial, decimal precoporhora)
        {
            this.precoinicial = precoinicial;
            this.precoporhora = precoporhora;
        }

        public void adicionarveiculo() //adiciona veiculos no estacionamento utilizando "lista"
        {
            Console.WriteLine("digite a placa do carro que estacionou:");
            string placaveiculo = Console.ReadLine();
            veiculos.Add(placaveiculo);
        }
        public void removerveiculo() //remove veiculos do estacionamento 
        {
            Console.WriteLine("digite a placa do veiculo para remover:");
            string placa = Console.ReadLine();

            //verifica se o veiculo existe antes de remover 
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("digite a quantidade de horas que o veiculo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valortotal = 0;
                valortotal = precoinicial + precoporhora * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"o veiculo de placa:{placa} foi removido e o preco total foi de: R$ {valortotal}");
            }
            else
            {
                Console.WriteLine("desculpe, esse veiculo nao esta estacionado aqui. Confira se digitou a placa corretamente");
            }

        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("os veiculos que estao estacionados aqui são:");
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nao há veiculos estacionados.");
            }
        }
    }
}
